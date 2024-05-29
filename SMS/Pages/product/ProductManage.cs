using SMS.BLL;
using SMS.DAL;
using SMS.FrmModels;
using SMS.Models.DModels;
using SMS.Pages.product;
using SMS.Utilities;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Pages
{
    public partial class ProductManage : UIPage
    {
        public ProductManage()
        {
            InitializeComponent();
        }
        ProductBLL proBLL = new ProductBLL();
        private void ProductManage_Load(object sender, EventArgs e)
        {
            FindProductList();
        }
        private void FindProductList()
        {
            string keywords = txtKeyWords.Text.Trim();
            List<ProductInfo> proList = proBLL.GetProductList(keywords);
            if (proList.Count > 0)
            {
                dgvProductList.AutoGenerateColumns = false;
                dgvProductList.DataSource = proList;
            }
            else
            {
                dgvProductList.DataSource = null;
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            ShowProductInfoPage(1, 0);
        }
        /// <summary>
        /// 打开产品信息页
        /// </summary>
        /// <param name="actType"></param>
        /// <param name="productId"></param>
        private void ShowProductInfoPage(int actType, int productId)
        {
            FrmProductInfo fProduct = new FrmProductInfo();
            fProduct.Tag = new FInfoData()
            {
                ActType = actType,
                FId = productId
            };
            //刷新列表页数据效果  委托，采用事件
            fProduct.ReloadList += () => FindProductList();
            fProduct.StartPosition = FormStartPosition.CenterScreen;
            fProduct.ShowDialog();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            FindProductList();
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var curCell = dgvProductList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string curVal = curCell.FormattedValue.ToString();
            ProductInfo proInfo = dgvProductList.Rows[e.RowIndex].DataBoundItem as ProductInfo;

            switch (curVal)
            {
                case "修改":
                    //打开产品信息页
                    ShowProductInfoPage(2, proInfo.ProductId);
                    break;
                case "删除":                    
                    DeleteProduct(proInfo.ProductId, 1);
                    break;
                
            }
        }
        /// <summary>
        /// 删除产品信息
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="isDeleted"></param>
        private void DeleteProduct(int productId, int isDeleted)
        {
            
            if (this.ShowAskDialog("产品删除","你确定要删除此产品吗？"))
            {
                bool bl = false;
                switch (isDeleted)
                {
                    case 1://逻辑删除
                        int reDel = proBLL.LogicDeleteProduct(productId);
                        if (reDel == 1)
                        {
                            bl = true;
                        }
                        else if (reDel == 2)
                        {
                            this.ShowErrorDialog("产品删除", "该产品已有库存，不能删除！");
                            return;
                        }
                        else
                        {
                            bl = false;
                        }
                        break;
                    case 0:
                        bl = proBLL.RecoverProduct(productId);
                        break;
                    case 2:
                        bl = proBLL.DeleteProduct(productId);
                        break;
                }
                if (bl)
                {
                    this.ShowSuccessDialog("产品删除", "删除成功！");
                    FindProductList();
                }
                else
                {
                    this.ShowErrorDialog("产品删除", "删除失败！");
                    return;
                }
            }
        }
    }
}
