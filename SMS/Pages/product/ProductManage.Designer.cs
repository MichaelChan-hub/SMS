namespace SMS.Pages
{
    partial class ProductManage
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
            dgvProductList = new Sunny.UI.UIDataGridView();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiButton2 = new Sunny.UI.UIButton();
            txtKeyWords = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            ProductId = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductNo = new DataGridViewTextBoxColumn();
            FitLowTemper = new DataGridViewTextBoxColumn();
            FitHighTemper = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewLinkColumn();
            colDel = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductList
            // 
            dgvProductList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductList.BackgroundColor = Color.White;
            dgvProductList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProductList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductList.ColumnHeadersHeight = 32;
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductList.Columns.AddRange(new DataGridViewColumn[] { ProductId, ProductName, ProductNo, FitLowTemper, FitHighTemper, colEdit, colDel });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvProductList.DefaultCellStyle = dataGridViewCellStyle5;
            dgvProductList.EnableHeadersVisualStyles = false;
            dgvProductList.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvProductList.GridColor = Color.FromArgb(80, 160, 255);
            dgvProductList.Location = new Point(11, 74);
            dgvProductList.Name = "dgvProductList";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProductList.RowHeadersWidth = 30;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgvProductList.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.SelectedIndex = -1;
            dgvProductList.Size = new Size(1107, 370);
            dgvProductList.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvProductList.TabIndex = 4;
            dgvProductList.CellContentClick += dgvProductList_CellContentClick;
            // 
            // uiPanel1
            // 
            uiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel1.Controls.Add(uiButton2);
            uiPanel1.Controls.Add(txtKeyWords);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiButton1);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(11, 6);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1107, 60);
            uiPanel1.TabIndex = 3;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton2
            // 
            uiButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.Location = new Point(464, 8);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(71, 40);
            uiButton2.TabIndex = 7;
            uiButton2.Text = "查询";
            uiButton2.Click += uiButton2_Click;
            // 
            // txtKeyWords
            // 
            txtKeyWords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtKeyWords.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKeyWords.Location = new Point(249, 8);
            txtKeyWords.Margin = new Padding(4, 5, 4, 5);
            txtKeyWords.MinimumSize = new Size(1, 16);
            txtKeyWords.Name = "txtKeyWords";
            txtKeyWords.Padding = new Padding(5);
            txtKeyWords.ShowText = false;
            txtKeyWords.Size = new Size(188, 40);
            txtKeyWords.TabIndex = 6;
            txtKeyWords.TextAlignment = ContentAlignment.MiddleLeft;
            txtKeyWords.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(124, 8);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(112, 40);
            uiLabel2.TabIndex = 5;
            uiLabel2.Text = "产品名称：";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            uiButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.Location = new Point(14, 8);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(71, 40);
            uiButton1.TabIndex = 4;
            uiButton1.Text = "新增";
            uiButton1.Click += uiButton1_Click;
            // 
            // ProductId
            // 
            ProductId.DataPropertyName = "ProductId";
            ProductId.HeaderText = "编号";
            ProductId.MinimumWidth = 6;
            ProductId.Name = "ProductId";
            ProductId.Width = 125;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "产品名称";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // ProductNo
            // 
            ProductNo.DataPropertyName = "ProductNo";
            ProductNo.HeaderText = "产品编号";
            ProductNo.MinimumWidth = 6;
            ProductNo.Name = "ProductNo";
            ProductNo.Width = 125;
            // 
            // FitLowTemper
            // 
            FitLowTemper.DataPropertyName = "FitLowTemper";
            FitLowTemper.HeaderText = "适合低温";
            FitLowTemper.MinimumWidth = 6;
            FitLowTemper.Name = "FitLowTemper";
            FitLowTemper.Width = 125;
            // 
            // FitHighTemper
            // 
            FitHighTemper.DataPropertyName = "FitHighTemper";
            FitHighTemper.HeaderText = "适合高温";
            FitHighTemper.MinimumWidth = 6;
            FitHighTemper.Name = "FitHighTemper";
            FitHighTemper.Width = 125;
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
            // ProductManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1129, 450);
            Controls.Add(dgvProductList);
            Controls.Add(uiPanel1);
            Name = "ProductManage";
            Text = "ProductManage";
            Load += ProductManage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIDataGridView dgvProductList;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UITextBox txtKeyWords;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton1;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductNo;
        private DataGridViewTextBoxColumn FitLowTemper;
        private DataGridViewTextBoxColumn FitHighTemper;
        private DataGridViewLinkColumn colEdit;
        private DataGridViewLinkColumn colDel;
    }
}