namespace SMS.Pages
{
    partial class RegionManage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            uiPanel1 = new Sunny.UI.UIPanel();
            cboStates = new Sunny.UI.UIComboBox();
            uiLabel3 = new Sunny.UI.UILabel();
            txtKeyWords = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            cboStores = new Sunny.UI.UIComboBox();
            uiButton2 = new Sunny.UI.UIButton();
            uiLabel2 = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            dgvSRegionList = new Sunny.UI.UIDataGridView();
            SRegionId = new DataGridViewTextBoxColumn();
            SRegionName = new DataGridViewTextBoxColumn();
            SRegionNo = new DataGridViewTextBoxColumn();
            Remark = new DataGridViewTextBoxColumn();
            AllowLowTemperature = new DataGridViewTextBoxColumn();
            AllowHighTemperature = new DataGridViewTextBoxColumn();
            TemperStateText = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewLinkColumn();
            colDel = new DataGridViewLinkColumn();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSRegionList).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel1.Controls.Add(cboStates);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(txtKeyWords);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(cboStores);
            uiPanel1.Controls.Add(uiButton2);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiButton1);
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
            // cboStates
            // 
            cboStates.DataSource = null;
            cboStates.FillColor = Color.White;
            cboStates.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboStates.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboStates.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboStates.Location = new Point(463, 14);
            cboStates.Margin = new Padding(4, 5, 4, 5);
            cboStates.MinimumSize = new Size(63, 0);
            cboStates.Name = "cboStates";
            cboStates.Padding = new Padding(0, 0, 30, 2);
            cboStates.Size = new Size(149, 36);
            cboStates.SymbolSize = 24;
            cboStates.TabIndex = 12;
            cboStates.TextAlignment = ContentAlignment.MiddleLeft;
            cboStates.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(398, 10);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(75, 40);
            uiLabel3.TabIndex = 11;
            uiLabel3.Text = "状态：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtKeyWords
            // 
            txtKeyWords.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKeyWords.Location = new Point(763, 14);
            txtKeyWords.Margin = new Padding(4, 5, 4, 5);
            txtKeyWords.MinimumSize = new Size(1, 16);
            txtKeyWords.Name = "txtKeyWords";
            txtKeyWords.Padding = new Padding(5);
            txtKeyWords.ShowText = false;
            txtKeyWords.Size = new Size(188, 36);
            txtKeyWords.TabIndex = 10;
            txtKeyWords.TextAlignment = ContentAlignment.MiddleLeft;
            txtKeyWords.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(658, 10);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(89, 40);
            uiLabel1.TabIndex = 9;
            uiLabel1.Text = "关键词：";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboStores
            // 
            cboStores.DataSource = null;
            cboStores.FillColor = Color.White;
            cboStores.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboStores.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboStores.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboStores.Location = new Point(194, 14);
            cboStores.Margin = new Padding(4, 5, 4, 5);
            cboStores.MinimumSize = new Size(63, 0);
            cboStores.Name = "cboStores";
            cboStores.Padding = new Padding(0, 0, 30, 2);
            cboStores.Size = new Size(149, 36);
            cboStores.SymbolSize = 24;
            cboStores.TabIndex = 8;
            cboStores.TextAlignment = ContentAlignment.MiddleLeft;
            cboStores.Watermark = "";
            // 
            // uiButton2
            // 
            uiButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(981, 10);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(71, 40);
            uiButton2.TabIndex = 7;
            uiButton2.Text = "查询";
            uiButton2.Click += uiButton2_Click;
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(129, 10);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(75, 40);
            uiLabel2.TabIndex = 5;
            uiLabel2.Text = "冷库：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            uiButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(19, 10);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(71, 40);
            uiButton1.TabIndex = 4;
            uiButton1.Text = "新增";
            uiButton1.Click += uiButton1_Click;
            // 
            // dgvSRegionList
            // 
            dgvSRegionList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvSRegionList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSRegionList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSRegionList.BackgroundColor = Color.White;
            dgvSRegionList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSRegionList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSRegionList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSRegionList.ColumnHeadersHeight = 32;
            dgvSRegionList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSRegionList.Columns.AddRange(new DataGridViewColumn[] { SRegionId, SRegionName, SRegionNo, Remark, AllowLowTemperature, AllowHighTemperature, TemperStateText, colEdit, colDel });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvSRegionList.DefaultCellStyle = dataGridViewCellStyle5;
            dgvSRegionList.EnableHeadersVisualStyles = false;
            dgvSRegionList.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvSRegionList.GridColor = Color.FromArgb(80, 160, 255);
            dgvSRegionList.Location = new Point(13, 82);
            dgvSRegionList.Name = "dgvSRegionList";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvSRegionList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvSRegionList.RowHeadersWidth = 30;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvSRegionList.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvSRegionList.RowTemplate.Height = 29;
            dgvSRegionList.SelectedIndex = -1;
            dgvSRegionList.Size = new Size(1107, 356);
            dgvSRegionList.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvSRegionList.TabIndex = 3;
            dgvSRegionList.CellContentClick += dgvSRegionList_CellContentClick;
            // 
            // SRegionId
            // 
            SRegionId.DataPropertyName = "SRegionId";
            SRegionId.HeaderText = "编号";
            SRegionId.MinimumWidth = 6;
            SRegionId.Name = "SRegionId";
            SRegionId.Width = 125;
            // 
            // SRegionName
            // 
            SRegionName.DataPropertyName = "SRegionName";
            SRegionName.HeaderText = "分区名称";
            SRegionName.MinimumWidth = 6;
            SRegionName.Name = "SRegionName";
            SRegionName.Width = 170;
            // 
            // SRegionNo
            // 
            SRegionNo.DataPropertyName = "SRegionNo";
            SRegionNo.HeaderText = "分区编码";
            SRegionNo.MinimumWidth = 6;
            SRegionNo.Name = "SRegionNo";
            SRegionNo.Width = 125;
            // 
            // Remark
            // 
            Remark.DataPropertyName = "SRTemperature";
            Remark.HeaderText = "温度";
            Remark.MinimumWidth = 6;
            Remark.Name = "Remark";
            Remark.Width = 125;
            // 
            // AllowLowTemperature
            // 
            AllowLowTemperature.DataPropertyName = "AllowLowTemperature";
            AllowLowTemperature.HeaderText = "低温";
            AllowLowTemperature.MinimumWidth = 6;
            AllowLowTemperature.Name = "AllowLowTemperature";
            AllowLowTemperature.Width = 125;
            // 
            // AllowHighTemperature
            // 
            AllowHighTemperature.DataPropertyName = "AllowHighTemperature";
            AllowHighTemperature.HeaderText = "高温";
            AllowHighTemperature.MinimumWidth = 6;
            AllowHighTemperature.Name = "AllowHighTemperature";
            AllowHighTemperature.Width = 125;
            // 
            // TemperStateText
            // 
            TemperStateText.DataPropertyName = "TemperStateText";
            TemperStateText.HeaderText = "状态";
            TemperStateText.MinimumWidth = 6;
            TemperStateText.Name = "TemperStateText";
            TemperStateText.Width = 125;
            // 
            // colEdit
            // 
            dataGridViewCellStyle3.NullValue = "修改";
            colEdit.DefaultCellStyle = dataGridViewCellStyle3;
            colEdit.HeaderText = "修改";
            colEdit.LinkBehavior = LinkBehavior.NeverUnderline;
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.TrackVisitedState = false;
            colEdit.Width = 125;
            // 
            // colDel
            // 
            dataGridViewCellStyle4.NullValue = "删除";
            colDel.DefaultCellStyle = dataGridViewCellStyle4;
            colDel.HeaderText = "删除";
            colDel.LinkBehavior = LinkBehavior.NeverUnderline;
            colDel.MinimumWidth = 6;
            colDel.Name = "colDel";
            colDel.TrackVisitedState = false;
            colDel.Width = 125;
            // 
            // RegionManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1129, 450);
            Controls.Add(dgvSRegionList);
            Controls.Add(uiPanel1);
            Name = "RegionManage";
            Text = "RegionManage";
            Load += RegionManage_Load;
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSRegionList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIDataGridView dgvSRegionList;
        private Sunny.UI.UIComboBox cboStores;
        private Sunny.UI.UITextBox txtKeyWords;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cboStates;
        private Sunny.UI.UILabel uiLabel3;
        private DataGridViewTextBoxColumn SRegionId;
        private DataGridViewTextBoxColumn SRegionName;
        private DataGridViewTextBoxColumn SRegionNo;
        private DataGridViewTextBoxColumn Remark;
        private DataGridViewTextBoxColumn AllowLowTemperature;
        private DataGridViewTextBoxColumn AllowHighTemperature;
        private DataGridViewTextBoxColumn TemperStateText;
        private DataGridViewLinkColumn colEdit;
        private DataGridViewLinkColumn colDel;
    }
}