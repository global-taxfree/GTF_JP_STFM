namespace GTF_STFM.Screen
{
    partial class Main2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main2));
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.TIL_ISSUE = new MetroFramework.Controls.MetroTile();
            this.TIL_NETWORK = new MetroFramework.Controls.MetroTile();
            this.TIL_USERNAME = new MetroFramework.Controls.MetroTile();
            this.TIL_PRE = new MetroFramework.Controls.MetroTile();
            this.TIL_SEARCH = new MetroFramework.Controls.MetroTile();
            this.TIL_LINE_1 = new MetroFramework.Controls.MetroTile();
            this.TIL_EMPTY_1 = new MetroFramework.Controls.MetroTile();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // metroPanel4
            // 
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(690, 82);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(324, 100);
            this.metroPanel4.TabIndex = 1;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(655, 274);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(428, 68);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(119, 30);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(437, 695);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // TIL_ISSUE
            // 
            this.TIL_ISSUE.ActiveControl = null;
            this.TIL_ISSUE.BackColor = System.Drawing.Color.Aqua;
            this.TIL_ISSUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TIL_ISSUE.Location = new System.Drawing.Point(0, 6);
            this.TIL_ISSUE.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_ISSUE.Name = "TIL_ISSUE";
            this.TIL_ISSUE.PaintTileCount = false;
            this.TIL_ISSUE.Size = new System.Drawing.Size(112, 85);
            this.TIL_ISSUE.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_ISSUE.TabIndex = 40;
            this.TIL_ISSUE.TabStop = false;
            this.TIL_ISSUE.Text = "Issue";
            this.TIL_ISSUE.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TIL_ISSUE.TileImage = ((System.Drawing.Image)(resources.GetObject("TIL_ISSUE.TileImage")));
            this.TIL_ISSUE.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.TIL_ISSUE.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TIL_ISSUE.UseSelectable = true;
            this.TIL_ISSUE.UseTileImage = true;
            this.TIL_ISSUE.Click += new System.EventHandler(this.TIL_ISSUE_Click);
            // 
            // TIL_NETWORK
            // 
            this.TIL_NETWORK.ActiveControl = null;
            this.TIL_NETWORK.BackColor = System.Drawing.Color.White;
            this.TIL_NETWORK.Location = new System.Drawing.Point(0, 674);
            this.TIL_NETWORK.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_NETWORK.Name = "TIL_NETWORK";
            this.TIL_NETWORK.Size = new System.Drawing.Size(112, 54);
            this.TIL_NETWORK.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_NETWORK.TabIndex = 44;
            this.TIL_NETWORK.TabStop = false;
            this.TIL_NETWORK.Text = "Online";
            this.TIL_NETWORK.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TIL_NETWORK.UseCustomForeColor = true;
            this.TIL_NETWORK.UseSelectable = true;
            // 
            // TIL_USERNAME
            // 
            this.TIL_USERNAME.ActiveControl = null;
            this.TIL_USERNAME.Location = new System.Drawing.Point(0, 619);
            this.TIL_USERNAME.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_USERNAME.Name = "TIL_USERNAME";
            this.TIL_USERNAME.Size = new System.Drawing.Size(112, 54);
            this.TIL_USERNAME.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_USERNAME.TabIndex = 43;
            this.TIL_USERNAME.TabStop = false;
            this.TIL_USERNAME.Text = "User Name 123456789123";
            this.TIL_USERNAME.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.TIL_USERNAME.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TIL_USERNAME.UseSelectable = true;
            // 
            // TIL_PRE
            // 
            this.TIL_PRE.ActiveControl = null;
            this.TIL_PRE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TIL_PRE.Location = new System.Drawing.Point(0, 264);
            this.TIL_PRE.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_PRE.Name = "TIL_PRE";
            this.TIL_PRE.Size = new System.Drawing.Size(112, 85);
            this.TIL_PRE.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_PRE.TabIndex = 42;
            this.TIL_PRE.TabStop = false;
            this.TIL_PRE.Text = "Config";
            this.TIL_PRE.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TIL_PRE.TileImage = ((System.Drawing.Image)(resources.GetObject("TIL_PRE.TileImage")));
            this.TIL_PRE.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.TIL_PRE.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TIL_PRE.UseSelectable = true;
            this.TIL_PRE.UseTileImage = true;
            this.TIL_PRE.Click += new System.EventHandler(this.TIL_PRE_Click);
            // 
            // TIL_SEARCH
            // 
            this.TIL_SEARCH.ActiveControl = null;
            this.TIL_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TIL_SEARCH.Location = new System.Drawing.Point(0, 92);
            this.TIL_SEARCH.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_SEARCH.Name = "TIL_SEARCH";
            this.TIL_SEARCH.Size = new System.Drawing.Size(112, 85);
            this.TIL_SEARCH.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_SEARCH.TabIndex = 41;
            this.TIL_SEARCH.TabStop = false;
            this.TIL_SEARCH.Text = "Search";
            this.TIL_SEARCH.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TIL_SEARCH.TileImage = ((System.Drawing.Image)(resources.GetObject("TIL_SEARCH.TileImage")));
            this.TIL_SEARCH.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.TIL_SEARCH.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TIL_SEARCH.UseSelectable = true;
            this.TIL_SEARCH.UseTileImage = true;
            this.TIL_SEARCH.Click += new System.EventHandler(this.TIL_SEARCH_Click);
            // 
            // TIL_LINE_1
            // 
            this.TIL_LINE_1.ActiveControl = null;
            this.TIL_LINE_1.Enabled = false;
            this.TIL_LINE_1.Location = new System.Drawing.Point(113, 5);
            this.TIL_LINE_1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_LINE_1.Name = "TIL_LINE_1";
            this.TIL_LINE_1.Size = new System.Drawing.Size(5, 723);
            this.TIL_LINE_1.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_LINE_1.TabIndex = 45;
            this.TIL_LINE_1.TabStop = false;
            this.TIL_LINE_1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_LINE_1.UseSelectable = true;
            // 
            // TIL_EMPTY_1
            // 
            this.TIL_EMPTY_1.ActiveControl = null;
            this.TIL_EMPTY_1.Enabled = false;
            this.TIL_EMPTY_1.Location = new System.Drawing.Point(0, 350);
            this.TIL_EMPTY_1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_EMPTY_1.Name = "TIL_EMPTY_1";
            this.TIL_EMPTY_1.Size = new System.Drawing.Size(112, 268);
            this.TIL_EMPTY_1.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_EMPTY_1.TabIndex = 46;
            this.TIL_EMPTY_1.TabStop = false;
            this.TIL_EMPTY_1.UseSelectable = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(0, 178);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(112, 85);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 47;
            this.metroTile1.TabStop = false;
            this.metroTile1.Text = "Online Search";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.TIL_TRXN_Click);
            // 
            // metroPanel5
            // 
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(655, 374);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(428, 68);
            this.metroPanel5.TabIndex = 2;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            // 
            // Main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 728);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.TIL_EMPTY_1);
            this.Controls.Add(this.TIL_LINE_1);
            this.Controls.Add(this.TIL_ISSUE);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.TIL_NETWORK);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.TIL_USERNAME);
            this.Controls.Add(this.TIL_PRE);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.TIL_SEARCH);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1360, 728);
            this.Name = "Main2";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main2_FormClosing);
            this.Load += new System.EventHandler(this.Main2_Load);
            this.ResizeEnd += new System.EventHandler(this.Main2_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Main2_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTile TIL_ISSUE;
        private MetroFramework.Controls.MetroTile TIL_NETWORK;
        private MetroFramework.Controls.MetroTile TIL_USERNAME;
        private MetroFramework.Controls.MetroTile TIL_PRE;
        private MetroFramework.Controls.MetroTile TIL_SEARCH;
        private MetroFramework.Controls.MetroTile TIL_LINE_1;
        private MetroFramework.Controls.MetroTile TIL_EMPTY_1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
    }
}