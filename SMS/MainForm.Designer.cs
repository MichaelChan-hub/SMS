namespace SMS
{
    partial class MainForm
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
            uiLabel1 = new Sunny.UI.UILabel();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            uiLabel2 = new Sunny.UI.UILabel();
            Footer.SuspendLayout();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // Footer
            // 
            Footer.Controls.Add(uiLabel2);
            Footer.Controls.Add(uiSymbolLabel2);
            Footer.Controls.Add(uiSymbolLabel1);
            Footer.Location = new Point(0, 688);
            Footer.Size = new Size(1264, 56);
            // 
            // Header
            // 
            Header.Controls.Add(uiLabel1);
            Header.Size = new Size(1264, 96);
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(3, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(325, 96);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "冷库温度管理系统";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiSymbolLabel1.Location = new Point(833, 0);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(431, 56);
            uiSymbolLabel1.Symbol = 561398;
            uiSymbolLabel1.TabIndex = 0;
            uiSymbolLabel1.Text = "时间：";
            uiSymbolLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            uiSymbolLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiSymbolLabel2.Location = new Point(0, 0);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(215, 56);
            uiSymbolLabel2.Symbol = 559413;
            uiSymbolLabel2.TabIndex = 1;
            uiSymbolLabel2.Text = "欢迎！";
            uiSymbolLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(214, 0);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(622, 56);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "九月酱油制作";
            uiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1264, 744);
            Name = "MainForm";
            Text = "主界面";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Footer.ResumeLayout(false);
            Header.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UILabel uiLabel2;
    }
}