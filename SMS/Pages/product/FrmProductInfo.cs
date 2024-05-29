using Common;
using SMS.BLL;
using SMS.FrmModels;
using SMS.Models.DModels;
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

namespace SMS.Pages.product
{
    public partial class FrmProductInfo : UIForm
    {
        public FrmProductInfo()
        {
            InitializeComponent();
        }

        public event Action ReloadList;//刷新产品列表页数据
        ProductBLL proBLL = new ProductBLL();
        private FInfoData fInfo = null;
        int actType = 1;//页面状态
        int productId = 0;//当前修改的产品编号
        string oldName = "";//原来的产品名称
        string oldNo = "";//原来的编码

        private void FrmProductInfo_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                fInfo = this.Tag as FInfoData;
            }
            InitPageInfo();
        }

        private void InitPageInfo()
        {
            if (fInfo != null)
            {
                actType = fInfo.ActType;
                string actName = "";
                if (actType == 1)
                {
                    actName = "新增";
                }
                else//修改
                {
                    productId = fInfo.FId;
                    //加载产品信息

                    GetProductInfo();
                    actName = "修改";
                }
                btnOK.Text = actName;

                this.Text += "----" + actName;
            }
        }

        /// <summary>
        /// 加载指定的产品信息
        /// </summary>
        private void GetProductInfo()
        {
            ProductInfo proInfo = proBLL.GetProductInfo(productId);
            if (proInfo != null)
            {
                txtProductNo.Text = proInfo.ProductNo;
                txtProductName.Text = proInfo.ProductName;
                txtLowTemper.Text = proInfo.FitLowTemper.ToString();
                txtHighTemper.Text = proInfo.FitHighTemper.ToString();
                oldName = proInfo.ProductName;
                oldNo = proInfo.ProductNo;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string conType = actType == 1 ? "新增" : "修改";
            string msgTitle = $"{conType}产品信息";
            //接收
            string proNo = txtProductNo.Text.Trim();
            string proName = txtProductName.Text.Trim();
            decimal? lowTemper = null;
            if (!string.IsNullOrEmpty(txtLowTemper.Text))
                lowTemper = txtLowTemper.Text.GetDecimal();
            decimal? highTemper = null;
            if (!string.IsNullOrEmpty(txtHighTemper.Text))
                highTemper = txtHighTemper.Text.GetDecimal();

            //判断
            if (string.IsNullOrEmpty(proName))
            {
                this.ShowErrorDialog(msgTitle, "产品名称不能为空！");
                txtProductName.Focus();
                return;
            }

            //检查名称和编码的存在性
            if (productId == 0 || productId > 0 && (proName != oldName || proNo != oldNo))
            {
                int intBl = 0;
                if (productId > 0)
                {
                    if (oldName == proName)
                        intBl = proBLL.ExistsProduct("", proNo);
                    else if (oldNo == proNo)
                        intBl = proBLL.ExistsProduct(proName, "");
                    else
                        intBl = proBLL.ExistsProduct(proName, proNo);
                }
                else
                {
                    intBl = proBLL.ExistsProduct(proName, proNo);
                }

                switch (intBl)
                {
                    case 0://都不存在
                        break;
                    case 1://Name 存在
                        this.ShowErrorDialog(msgTitle, "该产品名称已存在！");
                        break;
                    case 2://No 存在
                        this.ShowErrorDialog(msgTitle, "该产品编码已存在！");
                        break;
                    case 3://都 存在
                        this.ShowErrorDialog(msgTitle, "该产品名称和编码已存在！");
                        break;
                }
                if (intBl > 0)
                    return;
            }
            //温度值检查
            if (lowTemper == null)
            {
                this.ShowErrorDialog(msgTitle, "请设置产品的适合低温值！");
                txtLowTemper.Focus();
                return;
            }
            else if (highTemper == null)
            {
                this.ShowErrorDialog(msgTitle, "请设置产品的适合高温值！");
                txtHighTemper.Focus();
                return;
            }
            else if (lowTemper != null && highTemper != null && lowTemper > highTemper)
            {
                this.ShowErrorDialog(msgTitle, "产品的适合低温值不能高于高温值！");
                txtLowTemper.Focus();
                return;
            }
            //封装信息
            ProductInfo proInfo = new ProductInfo()
            {
                ProductId = productId,
                ProductName = proName,
                ProductNo = proNo,
                FitHighTemper = highTemper,
                FitLowTemper = lowTemper
            };

            //提交   ---   //做出响应
            if (actType == 1)//修改
            {
                int productNewId = proBLL.AddProductInfoWithId(proInfo);
                if (productNewId > 0)
                {
                    this.ShowSuccessDialog(msgTitle, $"产品：{proName}信息新增成功！");
                    //页面转换到修改状态
                    productId = productNewId;
                    actType = 2;
                    oldName = proName;
                    oldNo = proNo;
                    ReloadList?.Invoke();//刷新列表页
                    this.Close();
                }
                else
                {
                    this.ShowErrorDialog(msgTitle, $"产品：{proName}信息新增失败！");
                    return;
                }
            }
            else
            {
                bool bl = proBLL.UpdateProductInfo(proInfo);
                if (bl)
                {
                    this.ShowSuccessDialog(msgTitle, $"产品：{proName}信息修改成功！");
                    oldName = proName;
                    oldNo = proNo;
                    ReloadList?.Invoke();
                    this.Close();
                }
                else
                {
                    this.ShowErrorDialog(msgTitle, $"产品：{proName}信息修改失败！");
                    return;
                }
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
