namespace SMS
{
    partial class UStoreRegionBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSetTemperature = new Sunny.UI.UIButton();
            lblRegionName = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            panel2 = new Panel();
            uiRuler1 = new Sunny.UI.UIRuler();
            uiThermometer1 = new Sunny.UI.UIThermometer();
            SRTemperLight = new Sunny.UI.UILabel();
            lblTemperRange = new Sunny.UI.UILabel();
            uiLabel6 = new Sunny.UI.UILabel();
            lblSRTemperature = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(btnSetTemperature);
            panel1.Controls.Add(lblRegionName);
            panel1.Controls.Add(uiLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 45);
            panel1.TabIndex = 2;
            // 
            // btnSetTemperature
            // 
            btnSetTemperature.FillColor = Color.FromArgb(220, 0, 0);
            btnSetTemperature.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetTemperature.Location = new Point(267, 9);
            btnSetTemperature.MinimumSize = new Size(1, 1);
            btnSetTemperature.Name = "btnSetTemperature";
            btnSetTemperature.Radius = 25;
            btnSetTemperature.Size = new Size(62, 28);
            btnSetTemperature.TabIndex = 2;
            btnSetTemperature.Text = "升温";
            btnSetTemperature.Click += btnSetTemperature_Click;
            // 
            // lblRegionName
            // 
            lblRegionName.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegionName.ForeColor = Color.FromArgb(48, 48, 48);
            lblRegionName.Location = new Point(118, 0);
            lblRegionName.Name = "lblRegionName";
            lblRegionName.Size = new Size(143, 45);
            lblRegionName.TabIndex = 1;
            lblRegionName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            uiLabel1.Dock = DockStyle.Left;
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(0, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(112, 45);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "分区名称：";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Controls.Add(uiRuler1);
            panel2.Controls.Add(uiThermometer1);
            panel2.Controls.Add(SRTemperLight);
            panel2.Controls.Add(lblTemperRange);
            panel2.Controls.Add(uiLabel6);
            panel2.Controls.Add(lblSRTemperature);
            panel2.Controls.Add(uiLabel4);
            panel2.Controls.Add(uiLabel3);
            panel2.Controls.Add(uiLabel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 154);
            panel2.TabIndex = 3;
            // 
            // uiRuler1
            // 
            uiRuler1.BackColor = Color.Transparent;
            uiRuler1.Direction = Sunny.UI.UITrackBar.BarDirection.Vertical;
            uiRuler1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiRuler1.Location = new Point(253, 8);
            uiRuler1.MajorSize = 10;
            uiRuler1.MinimumSize = new Size(1, 1);
            uiRuler1.MinorCount = 4;
            uiRuler1.Name = "uiRuler1";
            uiRuler1.Size = new Size(45, 129);
            uiRuler1.StartValue = -20D;
            uiRuler1.StepCount = 4;
            uiRuler1.StepValue = 10D;
            uiRuler1.TabIndex = 9;
            uiRuler1.Text = "uiRuler1";
            // 
            // uiThermometer1
            // 
            uiThermometer1.BackColor = Color.FromArgb(192, 255, 255);
            uiThermometer1.BallSize = 16;
            uiThermometer1.FillColor = Color.FromArgb(128, 255, 255);
            uiThermometer1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiThermometer1.ForeColor = SystemColors.ControlLightLight;
            uiThermometer1.LineSize = 10;
            uiThermometer1.Location = new Point(287, 6);
            uiThermometer1.Maximum = 20;
            uiThermometer1.Minimum = -20;
            uiThermometer1.MinimumSize = new Size(1, 1);
            uiThermometer1.Name = "uiThermometer1";
            uiThermometer1.Size = new Size(40, 129);
            uiThermometer1.TabIndex = 8;
            uiThermometer1.Text = "uiThermometer1";
            // 
            // SRTemperLight
            // 
            SRTemperLight.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SRTemperLight.ForeColor = Color.FromArgb(48, 48, 48);
            SRTemperLight.Location = new Point(101, 101);
            SRTemperLight.Name = "SRTemperLight";
            SRTemperLight.Size = new Size(84, 29);
            SRTemperLight.TabIndex = 7;
            SRTemperLight.Text = "正常";
            SRTemperLight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTemperRange
            // 
            lblTemperRange.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTemperRange.ForeColor = Color.FromArgb(48, 48, 48);
            lblTemperRange.Location = new Point(101, 61);
            lblTemperRange.Name = "lblTemperRange";
            lblTemperRange.Size = new Size(123, 29);
            lblTemperRange.TabIndex = 6;
            lblTemperRange.Text = "-10~10℃";
            lblTemperRange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(131, 18);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(35, 29);
            uiLabel6.TabIndex = 4;
            uiLabel6.Text = "℃";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSRTemperature
            // 
            lblSRTemperature.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSRTemperature.ForeColor = Color.FromArgb(48, 48, 48);
            lblSRTemperature.Location = new Point(101, 18);
            lblSRTemperature.Name = "lblSRTemperature";
            lblSRTemperature.Size = new Size(35, 29);
            lblSRTemperature.TabIndex = 3;
            lblSRTemperature.Text = "0";
            lblSRTemperature.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(12, 101);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(83, 29);
            uiLabel4.TabIndex = 2;
            uiLabel4.Text = "当前状态：";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(12, 61);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(83, 29);
            uiLabel3.TabIndex = 1;
            uiLabel3.Text = "温度范围：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(12, 18);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(83, 29);
            uiLabel2.TabIndex = 0;
            uiLabel2.Text = "分区温度：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UStoreRegionBox
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UStoreRegionBox";
            Size = new Size(349, 199);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Sunny.UI.UIButton btnSetTemperature;
        private Sunny.UI.UILabel lblRegionName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel lblSRTemperature;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel lblTemperRange;
        private Sunny.UI.UIThermometer uiThermometer1;
        private Sunny.UI.UILabel SRTemperLight;
        private Sunny.UI.UIRuler uiRuler1;
    }
}
