using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using Florentis;

namespace GTF_STFM.Screen
{
    public partial class WizCap : Form
    {
        ILog m_Logger = null;
        bool ScriptIsRunning;               // flag for UI button respones
        WizardCallback Callback;           // For wizard callback 
        
        bool isCheck = false;

        public string confirmYn;

        public WizCap(string user_name, string alipay_login_id)
        {
            this.Opacity = 0;
            InitializeComponent();

            Callback = new WizardCallback();
            Callback.EventHandler = null;
            WizCtl.SetEventHandler(Callback);

            confirmYn = "";
            ScriptIsRunning = false;

            if (!ScriptIsRunning)
            {
                bool success = WizCtl.PadConnect();
                if (success)
                {
                    ScriptIsRunning = true;

                    WizCtl.Reset();
                    WizCtl.Licence = "AgAkAEy2cKydAQVXYWNvbQ1TaWduYXR1cmUgU0RLAgKBAgJkAACIAwEDZQA";
                    
                    WizCtl.AddObject(ObjectType.ObjectText, "txt", "left", 11, "Confirm Personal Information", null);

                    // insert checkbox
                    WizCtl.Font = new Font("Verdana", 10, FontStyle.Regular);
                    WizCtl.AddObject(ObjectType.ObjectText, "txt", 10, 60, " User Name : " + user_name + "\n User Login ID : " + alipay_login_id + "\n", null);

                    WizCtl.Font = new Font("Verdana", 10, FontStyle.Bold);
                    WizCtl.AddObject(ObjectType.ObjectCheckbox, "Check", "centre", 120, "My information is correct", 2);

                    // insert the buttons
                    WizCtl.Font = new Font("Verdana", 10, FontStyle.Regular);
                    WizCtl.AddObject(ObjectType.ObjectButton, "Cancel", "left", "bottom", "Cancel", 110);
                    WizCtl.AddObject(ObjectType.ObjectButton, "OK", "right", "bottom", "OK", 110);

                    // set callback when a button is pressed
                    WizCtl.Display();
                    Callback.EventHandler = new WizardCallback.Handler(Step1_Handler);
                    WizCtl.SetEventHandler(Callback);

                }
                else
                {
                    MessageBox.Show(this, "not connect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "Script is already running", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void scriptCancelled()
        {
            closeWizard();
        }

        private void closeWizard()
        {
            ScriptIsRunning = false;
            WizCtl.Reset();
            WizCtl.Display();
            WizCtl.PadDisconnect();
            Callback.EventHandler = null;       // remove handler
            WizCtl.SetEventHandler(Callback);

            Close();

        }

        private void Step1_Handler(object clt, object id, object type)
        {
            switch (id.ToString())
            {
                case "OK":
                    {
                        if (isCheck)
                        {
                            confirmYn = "Y";
                            closeWizard();
                        }
                        else
                        {
                            MessageBox.Show(this, "サインパッドのアリペイ情報がチェックされていません。", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            confirmYn = "N";
                        }
                        break;
                    }
                case "Cancel":
                    {
                        confirmYn = "C";
                        scriptCancelled();
                        break;
                    }
                case "Check":
                    {
                        isCheck = !isCheck;
                        break;
                    }
                default:
                    {
                        confirmYn = "E";
                        break;
                    }
             }
        }

    }
}
