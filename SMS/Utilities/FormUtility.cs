using SMS.BLL;
using SMS.FrmModels;
using SMS.Models.DModels;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Utilities
{
    public class FormUtility
    {
        /// <summary>
        /// 加载仓库下拉框
        /// </summary>
        /// <param name="cbo"></param>
        public static void LoadCboStores(UIComboBox cbo)
        {
            StoreBLL storeBLL = new StoreBLL();
            List<StoreInfo> storeList = storeBLL.GetAllStores();
            storeList.Insert(0, new StoreInfo()
            {
                StoreId = 0,
                StoreName = "-----请选择-----"
            });
            cbo.DisplayMember = "StoreName";
            cbo.ValueMember = "StoreId";
            cbo.DataSource = storeList;
            cbo.SelectedIndex = 0;
        }

        /// <summary>
        /// 分区状态列表
        /// </summary>
        /// <returns></returns>
        public static List<RegionStateModel> RegionStateList()
        {
            return new List<RegionStateModel>()
            {
                new RegionStateModel(){RegionState =-1,StateText="全部"},
                new RegionStateModel(){RegionState =0,StateText="低温"},
                new RegionStateModel(){RegionState =1,StateText="正常"},
                new RegionStateModel(){RegionState =2,StateText="高温"}
            };
        }
    }
}
