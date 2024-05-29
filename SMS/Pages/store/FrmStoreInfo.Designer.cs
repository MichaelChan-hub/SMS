namespace SMS.Pages.store
{
    partial class FrmStoreInfo
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
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            txtStoreRemark = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            txtStoreNo = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            txtStoreName = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(uiButton2);
            uiGroupBox1.Controls.Add(uiButton1);
            uiGroupBox1.Controls.Add(txtStoreRemark);
            uiGroupBox1.Controls.Add(uiLabel3);
            uiGroupBox1.Controls.Add(txtStoreNo);
            uiGroupBox1.Controls.Add(uiLabel2);
            uiGroupBox1.Controls.Add(txtStoreName);
            uiGroupBox1.Controls.Add(uiLabel1);
            uiGroupBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(31, 54);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(687, 392);
            uiGroupBox1.TabIndex = 0;
            uiGroupBox1.Text = "冷库信息";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(393, 330);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(125, 44);
            uiButton2.TabIndex = 7;
            uiButton2.Text = "返回";
            uiButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Click += uiButton2_Click;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(160, 330);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(125, 44);
            uiButton1.TabIndex = 6;
            uiButton1.Text = "确定";
            uiButton1.Click += uiButton1_Click;
            // 
            // txtStoreRemark
            // 
            txtStoreRemark.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreRemark.Location = new Point(201, 173);
            txtStoreRemark.Margin = new Padding(4, 5, 4, 5);
            txtStoreRemark.MinimumSize = new Size(1, 16);
            txtStoreRemark.Multiline = true;
            txtStoreRemark.Name = "txtStoreRemark";
            txtStoreRemark.Padding = new Padding(5);
            txtStoreRemark.ShowText = false;
            txtStoreRemark.Size = new Size(412, 140);
            txtStoreRemark.TabIndex = 5;
            txtStoreRemark.TextAlignment = ContentAlignment.MiddleLeft;
            txtStoreRemark.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(75, 173);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(125, 30);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "备注：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStoreNo
            // 
            txtStoreNo.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreNo.Location = new Point(201, 117);
            txtStoreNo.Margin = new Padding(4, 5, 4, 5);
            txtStoreNo.MinimumSize = new Size(1, 16);
            txtStoreNo.Name = "txtStoreNo";
            txtStoreNo.Padding = new Padding(5);
            txtStoreNo.ShowText = false;
            txtStoreNo.Size = new Size(246, 30);
            txtStoreNo.TabIndex = 3;
            txtStoreNo.TextAlignment = ContentAlignment.MiddleLeft;
            txtStoreNo.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(75, 117);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 30);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "冷库编号：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStoreName
            // 
            txtStoreName.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStoreName.Location = new Point(201, 60);
            txtStoreName.Margin = new Padding(4, 5, 4, 5);
            txtStoreName.MinimumSize = new Size(1, 16);
            txtStoreName.Name = "txtStoreName";
            txtStoreName.Padding = new Padding(5);
            txtStoreName.ShowText = false;
            txtStoreName.Size = new Size(246, 30);
            txtStoreName.TabIndex = 1;
            txtStoreName.TextAlignment = ContentAlignment.MiddleLeft;
            txtStoreName.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(75, 60);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 30);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "冷库名称：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmStoreInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(749, 481);
            Controls.Add(uiGroupBox1);
            MaximizeBox = false;
            Name = "FrmStoreInfo";
            Text = "冷库信息";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += FrmStoreInfo_Load;
            uiGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITextBox txtStoreName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtStoreRemark;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtStoreNo;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
    }
}