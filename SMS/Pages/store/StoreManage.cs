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
using SMS.BLL;
using SMS.Models.DModels;
using SMS.FrmModels;
using SMS.Pages.store;

namespace SMS.Pages
{
    public partial class StoreManage : UIPage
    {
        StoreBLL storeBLL = new StoreBLL();
        public StoreManage()
        {
            InitializeComponent();
        }

        private void StoreManage_Load(object sender, EventArgs e)
        {
            LoadStoreList();
        }

        private void LoadStoreList()
        {
            string keyword = uiTextBox1.Text.Trim();
            List<StoreInfo> storeList = storeBLL.GetStoreInfos(keyword, 0);

            if (storeList.Count > 0)
            {
                uiDataGridView1.AutoGenerateColumns = false;
                uiDataGridView1.DataSource = storeList;
                //SetEnableBtns(true);
            }
            else
            {
                uiDataGridView1.DataSource = null;
                //SetEnableBtns(false);
            }
        }

        /// <summary>
        /// 打开仓库信息页，新增或者修改页面
        /// </summary>
        /// <param name="actTpye">1为新增，2为修改</param>
        /// <param name="storeId"></param>
        private void ShowStoreInfoPage(int actTpye, int storeId)
        {
            FrmStoreInfo fStore = new FrmStoreInfo();
            fStore.Tag = new FInfoData()
            {
                ActType = actTpye,
                FId = storeId
            };
            //刷新列表页数据效果  委托，采用事件
            fStore.StoreListChanged += () => LoadStoreList();
            fStore.StartPosition = FormStartPosition.CenterScreen;
            fStore.ShowDialog();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            LoadStoreList();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            ShowStoreInfoPage(1, 0);
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = uiDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            string headText = cell.FormattedValue.ToString();
            StoreInfo store = uiDataGridView1.Rows[e.RowIndex].DataBoundItem as StoreInfo;

            switch (headText)
            {
                case "添加分区":
                    //打开添加仓库分区信息页
                    ShowStoreRegionInfoPage(store.StoreId);
                    break;
                case "修改":
                    //打开仓库信息页
                    ShowStoreInfoPage(2, store.StoreId);
                    break;
                case "删除":
                    //执行逻辑删除（假删除）
                    DeleteStore(store);
                    break;
            }

        }

        private void ShowStoreRegionInfoPage(int storeId)
        {
            FrmStoreRegion fRegion = new FrmStoreRegion();
            fRegion.Tag = new FInfoData()
            {
                ActType = 3,
                FId = storeId
            };
            //刷新列表页数据效果  委托，采用事件
            fRegion.StoreListChanged += () => LoadStoreList();
            fRegion.StartPosition = FormStartPosition.CenterScreen;
            fRegion.ShowDialog();
        }

        private void DeleteStore(StoreInfo storeInfo)
        {
            if (this.ShowAskDialog("冷库信息删除", "你确定要删除该冷库信息吗？"))
            {
                bool bl = false;

                int reDel = storeBLL.LogicDeleteStore(storeInfo.StoreId);
                if (reDel == 1)
                {
                  bl = true;
                }
                else if (reDel == 2)
                {
                    this.ShowErrorDialog("冷库信息删除","该冷库已添加了分区，不能删除");
                   return;
                }
                else
                {
                   bl = false;
                }                
                if (bl)
                {
                    this.ShowSuccessDialog("冷库信息删除", "删除成功");
                    LoadStoreList();
                }
                else
                {
                    this.ShowErrorDialog("冷库信息删除", "删除失败!");
                    return;
                }
            }
        }
    }
}
