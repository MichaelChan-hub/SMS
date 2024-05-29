using Common;
using SMS.BLL;
using SMS.DAL;
using SMS.FrmModels;
using SMS.Models.DModels;
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

namespace SMS.Pages.store
{
    public partial class FrmStoreRegion : UIForm
    {

        public FrmStoreRegion()
        {
            InitializeComponent();
        }
        private StoreRegionBLL srBLL = new StoreRegionBLL();
        public event Action StoreListChanged;
        public event Action ReloadList;//刷新仓库分区管理列表页数据
        private FInfoData fInfo = null;
        int actType = 1;//当前页面状态标识
        int regionId = 0;//当前修改的仓库编号
        string oldName = "";//修改前的分区名称
        string oldNo = "";//修改前的分区编码
        int oldStoreId = 0;//修改前的仓库编号
        private void FrmStoreRegionInfo_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                fInfo = this.Tag as FInfoData;
                InitStoreRegionInfo();
            }
        }
        /// <summary>
        /// 初始化页面信息
        /// </summary>
        private void InitStoreRegionInfo()
        {
            if (fInfo != null)
            {
                actType = fInfo.ActType;
                FormUtility.LoadCboStores(cboStores);
                string actName = "";
                switch (actType)
                {
                    case 1:
                        actName = "新增";
                        break;
                    case 2:
                        regionId = fInfo.FId;
                        //加载仓库                     
                        GetRegionInfo();
                        actName = "修改";
                        break;
                    case 3:
                        cboStores.SelectedValue = fInfo.FId;//StoreId
                        cboStores.Enabled = false;
                        actName = "新增";
                        break;
                }

                btnOk.Text = actName;
                this.Text += "----" + actName;
            }
        }
        /// <summary>
        /// 加载指定的分区信息
        /// </summary>
        private void GetRegionInfo()
        {
            StoreRegionInfo srInfo = srBLL.GetSRegionInfo(regionId);
            if (srInfo != null)
            {
                txtRegionName.Text = srInfo.SRegionName;
                txtRegionNo.Text = srInfo.SRegionNo;
                cboStores.SelectedValue = srInfo.StoreId;
                txtCurTemperature.Text = srInfo.SRTemperature == null ? "" : srInfo.SRTemperature.Value.ToString();
                txtLowTemperature.Text = srInfo.AllowLowTemperature == null ? "" : srInfo.AllowLowTemperature.Value.ToString();
                txtHighTemperature.Text = srInfo.AllowHighTemperature == null ? "" : srInfo.AllowHighTemperature.Value.ToString();
                txtRemark.Text = srInfo.Remark;
                oldName = srInfo.SRegionName;
                oldNo = srInfo.SRegionNo;
                oldStoreId = srInfo.StoreId;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //信息接收
            string regionName = txtRegionName.Text.Trim();
            string regionNo = txtRegionNo.Text.Trim();
            int storeId = cboStores.SelectedValue.GetInt();
            decimal? curTemperature = null;
            if (!string.IsNullOrEmpty(txtCurTemperature.Text))
                curTemperature = txtCurTemperature.Text.GetDecimal();
            decimal? lowTemperature = null, highTemperature = null;
            int regionState = 1;
            
            if (actType == 2)
            {
                if (!string.IsNullOrEmpty(txtLowTemperature.Text))
                    lowTemperature = txtLowTemperature.Text.GetDecimal();
                if (!string.IsNullOrEmpty(txtHighTemperature.Text))
                    highTemperature = txtHighTemperature.Text.GetDecimal();
            }
            string remark = txtRemark.Text.Trim();
            string msgTitle = "分区信息提交";
            if (string.IsNullOrEmpty(regionName))
            {
                this.ShowErrorDialog(msgTitle, "分区名称不能为空！");
                txtRegionName.Focus();
                return;
            }
            if (regionId == 0 || (regionId > 0 && (oldName != regionName || oldNo != regionNo)))
            {
                int intBl = 0;
                if (regionId > 0)
                {
                    if (oldName == regionName)
                        intBl = srBLL.ExistsStoreRegion("", regionNo);
                    else if (oldNo == regionNo)
                        intBl = srBLL.ExistsStoreRegion(regionName, "");
                    else
                        intBl = srBLL.ExistsStoreRegion(regionName, regionNo);
                }
                else
                {
                    intBl = srBLL.ExistsStoreRegion(regionName, regionNo);
                }
                switch (intBl)
                {
                    case 0://都不存在
                        break;
                    case 1://Name 存在
                        this.ShowErrorDialog(msgTitle, "该分区名称已存在！");
                        break;
                    case 2://No 存在
                        this.ShowErrorDialog(msgTitle, "该分区编码已存在！");
                        break;
                    case 3://都 存在
                        this.ShowErrorDialog(msgTitle, "该分区名称和编码已存在！");
                        break;
                }
                if (intBl > 0)
                    return;
            }
            if (storeId == 0)
            {
                this.ShowErrorDialog(msgTitle, "请选择所属冷库！");
                cboStores.Focus();
                return;
            }
            if (actType == 2)
            {
                if (lowTemperature != null && highTemperature != null && lowTemperature > highTemperature)
                {
                    this.ShowErrorDialog(msgTitle, "低温不能高于高温！");
                    txtLowTemperature.Focus();
                    return;
                }
                else if (lowTemperature != null && curTemperature != null && lowTemperature > curTemperature)
                {
                    regionState = 0;//低温
                }
                else if (highTemperature != null && curTemperature != null && highTemperature < curTemperature)
                {
                    regionState = 2;//高温
                }
            }

            //分区信息封装
            StoreRegionInfo srInfo = new StoreRegionInfo()
            {
                SRegionId = regionId,
                SRegionName = regionName,
                SRegionNo = regionNo,
                SRTemperature = curTemperature,
                StoreId = storeId,
                TemperState = regionState,
                Remark = remark
            };
            if (actType == 2)
            {
                if (lowTemperature != null)
                    srInfo.AllowLowTemperature = lowTemperature;
                if (highTemperature != null)
                    srInfo.AllowHighTemperature = highTemperature;
            }

            //提交
            bool bl = false;//提交状态
            if (actType == 1 || actType == 3)
            {
                int regionNewId = srBLL.AddStoreRegionWithId(srInfo);//返回新分区编号
                if (regionNewId > 0)
                {
                    bl = true;
                    regionId = regionNewId;
                    //actType = 2;
                }
            }
            else //修改
            {
                if (storeId != oldStoreId)
                    bl = srBLL.UpdateStoreRegion(srInfo, oldStoreId);
                else
                    bl = srBLL.UpdateStoreRegion(srInfo);
            }
            string actName = actType != 2 ? "新增" : "修改";
            string successType = bl ? "成功" : "失败";
            if (bl)
            {
                this.ShowSuccessDialog(msgTitle, $"分区：{regionName}{actName}{successType}!");
                if (actType == 1)
                {
                    actType = 2;
                    btnOk.Text = "修改";
                    oldName = regionName;
                    oldNo = regionNo;
                }
                if (actType == 3)
                    StoreListChanged?.Invoke();
                else
                {
                    ReloadList?.Invoke();
                    this.Close();
                }
                    
            }
            else
            {
                this.ShowErrorDialog(msgTitle, $"分区：{regionName}{actName}{successType}!");
                return;
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
