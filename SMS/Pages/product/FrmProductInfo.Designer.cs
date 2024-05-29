namespace SMS.Pages.product
{
    partial class FrmProductInfo
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
            txtHighTemper = new Sunny.UI.UITextBox();
            uiLabel4 = new Sunny.UI.UILabel();
            txtLowTemper = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiButton2 = new Sunny.UI.UIButton();
            btnOK = new Sunny.UI.UIButton();
            txtProductNo = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            txtProductName = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(txtHighTemper);
            uiGroupBox1.Controls.Add(uiLabel4);
            uiGroupBox1.Controls.Add(txtLowTemper);
            uiGroupBox1.Controls.Add(uiLabel3);
            uiGroupBox1.Controls.Add(uiButton2);
            uiGroupBox1.Controls.Add(btnOK);
            uiGroupBox1.Controls.Add(txtProductNo);
            uiGroupBox1.Controls.Add(uiLabel2);
            uiGroupBox1.Controls.Add(txtProductName);
            uiGroupBox1.Controls.Add(uiLabel1);
            uiGroupBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(57, 45);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(687, 392);
            uiGroupBox1.TabIndex = 1;
            uiGroupBox1.Text = "产品信息";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtHighTemper
            // 
            txtHighTemper.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHighTemper.Location = new Point(201, 231);
            txtHighTemper.Margin = new Padding(4, 5, 4, 5);
            txtHighTemper.MinimumSize = new Size(1, 16);
            txtHighTemper.Name = "txtHighTemper";
            txtHighTemper.Padding = new Padding(5);
            txtHighTemper.ShowText = false;
            txtHighTemper.Size = new Size(246, 30);
            txtHighTemper.TabIndex = 11;
            txtHighTemper.TextAlignment = ContentAlignment.MiddleLeft;
            txtHighTemper.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(75, 231);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(125, 30);
            uiLabel4.TabIndex = 10;
            uiLabel4.Text = "存储高温：";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLowTemper
            // 
            txtLowTemper.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLowTemper.Location = new Point(201, 178);
            txtLowTemper.Margin = new Padding(4, 5, 4, 5);
            txtLowTemper.MinimumSize = new Size(1, 16);
            txtLowTemper.Name = "txtLowTemper";
            txtLowTemper.Padding = new Padding(5);
            txtLowTemper.ShowText = false;
            txtLowTemper.Size = new Size(246, 30);
            txtLowTemper.TabIndex = 9;
            txtLowTemper.TextAlignment = ContentAlignment.MiddleLeft;
            txtLowTemper.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(75, 178);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(125, 30);
            uiLabel3.TabIndex = 8;
            uiLabel3.Text = "存储低温：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
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
            // btnOK
            // 
            btnOK.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.Location = new Point(160, 330);
            btnOK.MinimumSize = new Size(1, 1);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(125, 44);
            btnOK.TabIndex = 6;
            btnOK.Text = "确定";
            btnOK.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.Click += btnOK_Click;
            // 
            // txtProductNo
            // 
            txtProductNo.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductNo.Location = new Point(201, 117);
            txtProductNo.Margin = new Padding(4, 5, 4, 5);
            txtProductNo.MinimumSize = new Size(1, 16);
            txtProductNo.Name = "txtProductNo";
            txtProductNo.Padding = new Padding(5);
            txtProductNo.ShowText = false;
            txtProductNo.Size = new Size(246, 30);
            txtProductNo.TabIndex = 3;
            txtProductNo.TextAlignment = ContentAlignment.MiddleLeft;
            txtProductNo.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(75, 117);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 30);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "产品编号：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(201, 60);
            txtProductName.Margin = new Padding(4, 5, 4, 5);
            txtProductName.MinimumSize = new Size(1, 16);
            txtProductName.Name = "txtProductName";
            txtProductName.Padding = new Padding(5);
            txtProductName.ShowText = false;
            txtProductName.Size = new Size(246, 30);
            txtProductName.TabIndex = 1;
            txtProductName.TextAlignment = ContentAlignment.MiddleLeft;
            txtProductName.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(75, 60);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 30);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "产品名称：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmProductInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(uiGroupBox1);
            Name = "FrmProductInfo";
            Text = "ProductInfo";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            Load += FrmProductInfo_Load;
            uiGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton btnOK;
        private Sunny.UI.UITextBox txtProductNo;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtProductName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtHighTemper;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtLowTemper;
        private Sunny.UI.UILabel uiLabel3;
    }
}