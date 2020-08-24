using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MetroFramework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.IO;
using GTF_STFM.Util;
using GTF_STFM.Tran;
using Newtonsoft.Json.Linq;
using Florentis;

namespace GTF_STFM.Screen
{
    public partial class ScanAli : MetroFramework.Forms.MetroForm
    {
        ILog m_Logger = null;
        public string user_name = "";
        public string alipay_barcode_no = "";
        public string alipayID = "";
        public string alipay_login_id = "";
        public string out_order_no = "";
        public string confirm_date = "";
        public string confirm_time = "";

        public string confirmYn = "";

        public ScanAli(ILog Logger = null)
        {
            m_Logger = Logger;
            if (m_Logger == null)
                m_Logger = LogManager.GetLogger("");

            InitializeComponent();
            Init();
                        
            this.DialogResult = DialogResult.Cancel;
        }

        private void Init()
        {
            TXT_BARCODE_NO.Clear();
            TXT_BARCODE_NO.Enabled = true;
            TXT_BARCODE_NO.Visible = true;
            TXT_BARCODE_NO.Focus();
        }

        private void SACN_BARCODE()
        {

            if (TXT_BARCODE_NO.Equals("") || TXT_BARCODE_NO.Text.Length != 18)
            {
                MetroMessageBox.Show(this, Constants.getMessage("ERROR_ALI_ID"), "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Init();
            }
            else
            {
                Transaction tran = new Transaction();
                JObject jsonReq = new JObject();
                jsonReq.Add("barcode_no", TXT_BARCODE_NO.Text);
                jsonReq.Add("tot_refund_amt", "345");
                jsonReq.Add("tot_buy_amt", "5000");
                jsonReq.Add("tml_id", Constants.TML_ID);

                string aliResult = tran.AlipayQR(jsonReq.ToString());

                string result_message = "";
                string result_flag = "";

                if (aliResult != null)
                {
                    JArray a = JArray.Parse(aliResult);

                    for (int i = 0; i < a.Count; i++)
                    {
                        JObject tempObj = (JObject)a[i];

                        alipay_barcode_no = TXT_BARCODE_NO.Text;
                        result_flag = tempObj["result_flag"].ToString();
                        result_message = tempObj["result_message"].ToString();

                        if (tempObj["result_flag"].ToString().Equals("T")){
                            alipayID = tempObj["alipay_user_id"].ToString();
                            user_name = tempObj["user_name"].ToString();
                            alipay_login_id = tempObj["alipay_login_id"].ToString();
                            out_order_no = tempObj["out_order_no"].ToString();
                            confirm_date = tempObj["confirm_date"].ToString();
                            confirm_time = tempObj["confirm_time"].ToString();
                        }
                        else
                        {
                            break;
                        }

                        tempObj = null;
                    }

                    if (result_flag != "T")
                    {
                        MetroMessageBox.Show(this, result_message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Init();
                    }
                    else
                    {
                        TXT_USER_NAME.Text = user_name;
                        TXT_LOGIN_ID.Text = alipay_login_id;

                    }

                } else
                {
                    MetroMessageBox.Show(this, "取引が正常ではありません。\n 他還付方法を選択または最初からやり直してください。.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                tran = null;
            }

        }

        private void SACN_BARCODE(string ReqData)
        {

            if (TXT_BARCODE_NO.Equals("") || TXT_BARCODE_NO.Text.Length != 18)
            {
                MetroMessageBox.Show(this, Constants.getMessage("ERROR_ALI_ID"), "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Init();
            }
            else
            {
                Transaction tran = new Transaction();
                JObject jsonReq = new JObject();
                jsonReq.Add("barcode_no", TXT_BARCODE_NO.Text);

                tran.AlipayQR(TXT_BARCODE_NO.Text);
            }
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            alipay_barcode_no = "";
            alipayID = "";
            user_name = "";
            alipay_login_id = "";
            out_order_no = "";
            confirm_date = "";
            confirm_time = "";
            this.DialogResult = DialogResult.Cancel;
        }

        private void TXT_BARCODE_NO_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SACN_BARCODE();
            }

        }

        private void BTN_CONFIRM_Click(object sender, EventArgs e)
        {

            if (alipay_barcode_no.Equals("") || user_name.Equals(""))
            {
                MetroMessageBox.Show(this, "もう一度、バーコード(QRコード)をスキャンしてください。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_BARCODE_NO.Focus();
            }
            else
            {
                WizCap wiz = new WizCap(user_name, alipay_login_id);
                wiz.ShowDialog(this);

                confirmYn = wiz.confirmYn;
                if (confirmYn.Equals("C"))
                {
                    MetroMessageBox.Show(this, "お客様がキャンセルボタンを押しました。再度、確認してください。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
                
            }
        }
    }
}
