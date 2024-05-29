namespace SMS
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            uiStyleManager1 = new Sunny.UI.UIStyleManager(components);
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            UserName = new Sunny.UI.UITextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            Password = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiStyleManager1
            // 
            uiStyleManager1.GlobalFontName = "微软雅黑";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("微软雅黑", 22.8F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.White;
            uiLabel1.Location = new Point(201, 80);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(350, 66);
            uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            uiLabel1.TabIndex = 2;
            uiLabel1.Text = "冷库温度监控系统";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.White;
            uiLabel2.Location = new Point(-1, 0);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(75, 58);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "账户：";
            uiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserName
            // 
            UserName.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserName.Location = new Point(81, 10);
            UserName.Margin = new Padding(4, 5, 4, 5);
            UserName.MinimumSize = new Size(1, 16);
            UserName.Name = "UserName";
            UserName.Padding = new Padding(5);
            UserName.ShowText = false;
            UserName.Size = new Size(313, 39);
            UserName.TabIndex = 4;
            UserName.TextAlignment = ContentAlignment.MiddleLeft;
            UserName.Watermark = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(UserName);
            panel1.Controls.Add(uiLabel2);
            panel1.Location = new Point(168, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 60);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Password);
            panel2.Controls.Add(uiLabel3);
            panel2.Location = new Point(168, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 60);
            panel2.TabIndex = 6;
            // 
            // Password
            // 
            Password.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(81, 10);
            Password.Margin = new Padding(4, 5, 4, 5);
            Password.MinimumSize = new Size(1, 16);
            Password.Name = "Password";
            Password.Padding = new Padding(5);
            Password.PasswordChar = '*';
            Password.ShowText = false;
            Password.Size = new Size(313, 39);
            Password.TabIndex = 4;
            Password.TextAlignment = ContentAlignment.MiddleLeft;
            Password.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.White;
            uiLabel3.Location = new Point(-1, 0);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.RightToLeft = RightToLeft.No;
            uiLabel3.Size = new Size(75, 58);
            uiLabel3.TabIndex = 3;
            uiLabel3.Text = "密码：";
            uiLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(168, 330);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(411, 43);
            uiButton1.TabIndex = 7;
            uiButton1.Text = "登录";
            uiButton1.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Click += Login;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginbg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 453);
            Controls.Add(uiButton1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(uiLabel1);
            Name = "LoginForm";
            Text = "冷库温度监控系统——登录";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIStyleManager uiStyleManager1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox UserName;
        private Panel panel1;
        private Panel panel2;
        private Sunny.UI.UITextBox Password;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton uiButton1;
    }
}
