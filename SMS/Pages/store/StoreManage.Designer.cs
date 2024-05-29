namespace SMS.Pages
{
    partial class StoreManage
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiButton2 = new Sunny.UI.UIButton();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            uiDataGridView1 = new Sunny.UI.UIDataGridView();
            StoreId = new DataGridViewTextBoxColumn();
            StoreNo = new DataGridViewTextBoxColumn();
            StoreName = new DataGridViewTextBoxColumn();
            RegionCount = new DataGridViewTextBoxColumn();
            Remark = new DataGridViewTextBoxColumn();
            colAddRegion = new DataGridViewButtonColumn();
            colEdit = new DataGridViewLinkColumn();
            colDel = new DataGridViewLinkColumn();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel1.Controls.Add(uiButton2);
            uiPanel1.Controls.Add(uiTextBox1);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiButton1);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(10, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1107, 60);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton2
            // 
            uiButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(460, 10);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(71, 40);
            uiButton2.TabIndex = 3;
            uiButton2.Text = "查询";
            uiButton2.Click += uiButton2_Click;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiTextBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.Location = new Point(245, 10);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(188, 40);
            uiTextBox1.TabIndex = 2;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(120, 10);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(112, 40);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "冷库名称：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            uiButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(10, 10);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(71, 40);
            uiButton1.TabIndex = 0;
            uiButton1.Text = "新增";
            uiButton1.Click += uiButton1_Click;
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            uiDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiDataGridView1.BackgroundColor = Color.White;
            uiDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { StoreId, StoreNo, StoreName, RegionCount, Remark, colAddRegion, colEdit, colDel });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.GridColor = Color.FromArgb(80, 160, 255);
            uiDataGridView1.Location = new Point(10, 68);
            uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView1.RowHeadersWidth = 30;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.RowTemplate.Height = 29;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.Size = new Size(1107, 370);
            uiDataGridView1.StripeOddColor = Color.FromArgb(235, 243, 255);
            uiDataGridView1.TabIndex = 2;
            uiDataGridView1.CellContentClick += uiDataGridView1_CellContentClick;
            // 
            // StoreId
            // 
            StoreId.DataPropertyName = "StoreId";
            StoreId.HeaderText = "编号";
            StoreId.MinimumWidth = 6;
            StoreId.Name = "StoreId";
            StoreId.Width = 125;
            // 
            // StoreNo
            // 
            StoreNo.DataPropertyName = "StoreNo";
            StoreNo.HeaderText = "冷库编码";
            StoreNo.MinimumWidth = 6;
            StoreNo.Name = "StoreNo";
            StoreNo.Width = 125;
            // 
            // StoreName
            // 
            StoreName.DataPropertyName = "StoreName";
            StoreName.HeaderText = "冷库名称";
            StoreName.MinimumWidth = 6;
            StoreName.Name = "StoreName";
            StoreName.Width = 125;
            // 
            // RegionCount
            // 
            RegionCount.DataPropertyName = "RegionCount";
            RegionCount.HeaderText = "分区数量";
            RegionCount.MinimumWidth = 6;
            RegionCount.Name = "RegionCount";
            RegionCount.Width = 125;
            // 
            // Remark
            // 
            Remark.DataPropertyName = "Remark";
            Remark.HeaderText = "描述";
            Remark.MinimumWidth = 6;
            Remark.Name = "Remark";
            Remark.Width = 125;
            // 
            // colAddRegion
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "添加分区";
            colAddRegion.DefaultCellStyle = dataGridViewCellStyle3;
            colAddRegion.HeaderText = "添加分区";
            colAddRegion.MinimumWidth = 6;
            colAddRegion.Name = "colAddRegion";
            colAddRegion.Resizable = DataGridViewTriState.True;
            colAddRegion.Width = 125;
            // 
            // colEdit
            // 
            dataGridViewCellStyle4.NullValue = "修改";
            colEdit.DefaultCellStyle = dataGridViewCellStyle4;
            colEdit.HeaderText = "修改";
            colEdit.LinkBehavior = LinkBehavior.NeverUnderline;
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.TrackVisitedState = false;
            colEdit.Width = 125;
            // 
            // colDel
            // 
            dataGridViewCellStyle5.NullValue = "删除";
            colDel.DefaultCellStyle = dataGridViewCellStyle5;
            colDel.HeaderText = "删除";
            colDel.LinkBehavior = LinkBehavior.NeverUnderline;
            colDel.MinimumWidth = 6;
            colDel.Name = "colDel";
            colDel.TrackVisitedState = false;
            colDel.Width = 125;
            // 
            // StoreManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1129, 450);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiPanel1);
            Name = "StoreManage";
            Text = "StoreManage";
            Load += StoreManage_Load;
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton1;
        private DataGridViewTextBoxColumn StoreId;
        private DataGridViewTextBoxColumn StoreNo;
        private DataGridViewTextBoxColumn StoreName;
        private DataGridViewTextBoxColumn RegionCount;
        private DataGridViewTextBoxColumn Remark;
        private DataGridViewButtonColumn colAddRegion;
        private DataGridViewLinkColumn colEdit;
        private DataGridViewLinkColumn colDel;
    }
}