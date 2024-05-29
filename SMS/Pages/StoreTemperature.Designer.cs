namespace SMS.Pages
{
    partial class StoreTemperature
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
            uiPanel1 = new Sunny.UI.UIPanel();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            cboStores = new Sunny.UI.UIComboBox();
            flpRegionList = new FlowLayoutPanel();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel1.Controls.Add(uiButton2);
            uiPanel1.Controls.Add(uiButton1);
            uiPanel1.Controls.Add(cboStores);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(13, 14);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1107, 60);
            uiPanel1.TabIndex = 2;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(892, 11);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(98, 36);
            uiButton2.TabIndex = 2;
            uiButton2.Text = "温度检测";
            uiButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Click += uiButton2_Click;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(302, 11);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(98, 36);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "选择";
            uiButton1.Click += uiButton1_Click;
            // 
            // cboStores
            // 
            cboStores.DataSource = null;
            cboStores.FillColor = Color.White;
            cboStores.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboStores.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboStores.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboStores.Location = new Point(40, 11);
            cboStores.Margin = new Padding(4, 5, 4, 5);
            cboStores.MinimumSize = new Size(63, 0);
            cboStores.Name = "cboStores";
            cboStores.Padding = new Padding(0, 0, 30, 2);
            cboStores.Size = new Size(188, 36);
            cboStores.SymbolSize = 24;
            cboStores.TabIndex = 0;
            cboStores.TextAlignment = ContentAlignment.MiddleLeft;
            cboStores.Watermark = "";
            // 
            // flpRegionList
            // 
            flpRegionList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpRegionList.Location = new Point(13, 82);
            flpRegionList.Name = "flpRegionList";
            flpRegionList.Size = new Size(1107, 356);
            flpRegionList.TabIndex = 3;
            // 
            // StoreTemperature
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1129, 450);
            Controls.Add(flpRegionList);
            Controls.Add(uiPanel1);
            Name = "StoreTemperature";
            Text = "StoreTemperature";
            Load += StoreTemperature_Load;
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIComboBox cboStores;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private FlowLayoutPanel flpRegionList;
    }
}