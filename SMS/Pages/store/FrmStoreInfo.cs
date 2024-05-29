using SMS.BLL;
using SMS.FrmModels;
using SMS.Models.DModels;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Pages.store
{
    public partial class FrmStoreInfo : UIForm
    {
        public FrmStoreInfo()
        {
            InitializeComponent();
        }

        StoreBLL storeBLL = new StoreBLL();
        public event Action StoreListChanged;//修改或新增过后，冷库列表刷新事件
        private FInfoData fInfoData = null;

        int storeId = 0;//当前修改的仓库编号
        string oldName = "";//修改前的名称
        string oldNo = "";//修改前的编码
        int actType = 1;//新增


        private void uiButton1_Click(object sender, EventArgs e)
        {
            string msgTitle = actType == 1 ? "新增冷库" : "修改信息";
            string storeName = txtStoreName.Text.Trim();
            string storeNo = txtStoreNo.Text.Trim();
            string remark = txtStoreRemark.Text.Trim();

            // 判断：非空、存在性
            if (string.IsNullOrEmpty(storeName))
            {
                this.ShowErrorDialog(msgTitle, "仓库名称不能为空！");
                txtStoreName.Focus();
                return;
            }

            if (storeId == 0 || (storeId > 0 && (oldName != storeName || oldNo != storeNo)))
            {
                int intBl = 0;
                if (storeId > 0)
                {
                    if (oldName == storeName)
                        intBl = storeBLL.ExistsStore("", storeNo);
                    else if (oldNo == storeNo)
                        intBl = storeBLL.ExistsStore(storeName, "");
                    else
                        intBl = storeBLL.ExistsStore(storeName, storeNo);
                }
                else
                {
                    intBl = storeBLL.ExistsStore(storeName, storeNo);
                }
                switch (intBl)
                {
                    case 0://都不存在
                        break;
                    case 1://Name 存在
                        this.ShowErrorDialog(msgTitle, "该仓库名称已存在！");
                        break;
                    case 2://No 存在
                        this.ShowErrorDialog(msgTitle, "该仓库编码已存在！");
                        break;
                    case 3://都 存在
                        this.ShowErrorDialog(msgTitle, "该仓库名称和编码已存在！");
                        break;
                }
                if (intBl > 0)
                    return;
            }

            // 信息封装
            StoreInfo storeInfo = new StoreInfo()
            {
                StoreId = storeId,
                StoreNo = storeNo,
                StoreName = storeName,
                Remark = remark
            };

            // 提交表单：
            if (actType == 1)
            {
                int storeNewId = storeBLL.AddStore(storeInfo);
                if (storeNewId > 0)
                {
                    this.ShowSuccessDialog(msgTitle, $"仓库：{storeName}信息新增成功！");
                    storeId = storeNewId;
                    actType = 2;
                    oldName = storeName;
                    oldNo = storeNo;
                    StoreListChanged?.Invoke();
                }
                else
                {
                    this.ShowErrorDialog(msgTitle, $"仓库：{storeName}信息新增成功！");
                    return;
                }
            }
            else
            {
                bool bl = storeBLL.UpdateStore(storeInfo);
                if (bl)
                {
                    this.ShowSuccessDialog(msgTitle, $"仓库：{storeName}信息修改成功！");
                    oldName = storeName;
                    oldNo = storeNo;
                    StoreListChanged?.Invoke();
                }
                else
                {
                    this.ShowErrorDialog(msgTitle, $"仓库：{storeName}信息修改失败！");
                    return;
                }
            }
            this.Close();
        }

        private void FrmStoreInfo_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                fInfoData = this.Tag as FInfoData;
                InitPageInfo();
            }
        }

        //初始化页面信息
        private void InitPageInfo()
        {
            if (fInfoData != null)
            {
                actType = fInfoData.ActType;
                if (actType == 1)
                {
                    this.Text = "新增冷库";
                    ClearInfo();

                }
                else//修改
                {
                    storeId = fInfoData.FId;
                    //加载仓库
                    GetStore();
                    this.Text = "修改信息";
                }


            }
        }

        /// <summary>
        /// 清空处理
        /// </summary>
        private void ClearInfo()
        {
            txtStoreRemark.Clear();
            txtStoreName.Clear();
            txtStoreNo.Clear();
            actType = 1;
            storeId = 0;
            oldName = "";
            oldNo = "";
        }
        /// <summary>
        /// 加载仓库信息
        /// </summary>
        private void GetStore()
        {
            StoreInfo storeInfo = storeBLL.GetStore(storeId);
            if (storeInfo != null)
            {
                txtStoreName.Text = storeInfo.StoreName;
                txtStoreNo.Text = storeInfo.StoreNo;
                txtStoreRemark.Text = storeInfo.Remark;

                oldName = storeInfo.StoreName;
                oldNo = storeInfo.StoreNo;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
