using Common;
using SMS.BLL;
using SMS.FrmModels;
using SMS.Models.VModels;
using SMS.Pages.store;
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
    public partial class RegionManage : UIPage
    {
        public RegionManage()
        {
            InitializeComponent();
        }
        StoreRegionBLL srBLL = new StoreRegionBLL();

        /// <summary>
        /// 新增冷库分区
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            ShowStoreRegionInfoPage(1, 0);
        }

        private void RegionManage_Load(object sender, EventArgs e)
        {
            //加载冷库下拉框
            FormUtility.LoadCboStores(cboStores);
            //加载状态下拉框
            LoadCboStates();

            FindStoreRegionList();//加载所有的分区信息
        }

        private void LoadCboStates()
        {
            List<RegionStateModel> stateList = FormUtility.RegionStateList();
            cboStates.DisplayMember = "StateText";
            cboStates.ValueMember = "RegionState";
            cboStates.DataSource = stateList;
            cboStates.SelectedIndex = 0;
        }

        /// <summary>
        /// 查询冷库区列表
        /// </summary>
        private void FindStoreRegionList()
        {
            int storeId = cboStores.SelectedValue.GetInt();
            int stateId = cboStates.SelectedValue.GetInt();
            string keywords = txtKeyWords.Text.Trim();
            List<ViewStoreRegionInfo> regionList = srBLL.FindStoreRegionList(storeId, stateId, keywords);
            if (regionList.Count > 0)
            {
                dgvSRegionList.AutoGenerateColumns = false;
                dgvSRegionList.DataSource = regionList;
            }
            else
            {
                dgvSRegionList.DataSource = null;
            }
        }




        /// <summary>
        /// 打开仓库分区信息页面
        /// </summary>
        /// <param name="actType"></param>
        /// <param name="sRegionId"></param>
        private void ShowStoreRegionInfoPage(int actType, int sRegionId)
        {
            FrmStoreRegion fStoreRegion = new FrmStoreRegion();
            fStoreRegion.Tag = new FInfoData()
            {
                ActType = actType,
                FId = sRegionId
            };
            //刷新列表页数据效果,采用事件
            fStoreRegion.ReloadList += () => FindStoreRegionList();
            fStoreRegion.StartPosition = FormStartPosition.CenterScreen;
            fStoreRegion.ShowDialog();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            FindStoreRegionList();
        }

        private void dgvSRegionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvSRegionList.Rows[e.RowIndex].Cells[e.ColumnIndex];//当前点击的单元格
            string headText = cell.FormattedValue.ToString();
            //分区数据对象
            ViewStoreRegionInfo region = dgvSRegionList.Rows[e.RowIndex].DataBoundItem as ViewStoreRegionInfo;
            switch (headText)
            {
                case "修改":
                    //打开仓库分区信息页
                    ShowStoreRegionInfoPage(2, region.SRegionId);
                    break;
                case "删除":
                    //执行逻辑删除（假删除）
                    DeleteStoreRegion(region, 1);
                    break;            
            }
        }
        /// <summary>
        /// 仓库分区删除、恢复、移除处理
        /// </summary>
        /// <param name="region"></param>
        /// <param name="isDeleted"></param>
        private void DeleteStoreRegion(ViewStoreRegionInfo region, int isDeleted)
        {
            if (this.ShowAskDialog("分区删除", "你确定要删除该分区吗？"))
            {
                bool bl = false;
                int reDel = srBLL.LogicDeleteStoreRegion(region.SRegionId, region.StoreId);
                if (reDel == 1)
                {
                    bl = true;
                }
                else if (reDel == 2)
                {
                    this.ShowErrorDialog("分区删除", $"该仓库分区已添加了产品，不能删除！");
                    return;
                }
                else
                {
                    bl = false;
                }
                      
                if (bl)
                {
                    this.ShowErrorDialog("分区删除", "删除成功！");
                    FindStoreRegionList();
                }
                else
                {
                    this.ShowErrorDialog("分区删除", "删除失败！");
                    return;
                }
            }
        }
    }
}
