using SMS.DAL;
using SMS.Models.DModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.BLL
{
    public class StoreBLL
    {
        private StoreDAL storeDAL = new StoreDAL();

        /// <summary>
        /// 条件查询仓库信息列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="isDel"></param>
        /// <returns></returns>
        public List<StoreInfo> GetStoreInfos(string keywords, int isDel)
        {
            return storeDAL.GetStoreInfos(keywords, isDel);
        }


        /// <summary>
        /// 根据id获取指定的仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public StoreInfo GetStore(int storeId)
        {
            return storeDAL.GetStore(storeId);
        }


        /// <summary>
        /// 检查冷库编码或名称是否已存在
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="storeNo"></param>
        /// <returns></returns>
        public int ExistsStore(string storeName, string storeNo)
        {
            bool[] bls = storeDAL.ExistsStore(storeName, storeNo);
            bool blName = bls[0];
            bool blNo = bls[1];
            if (blName && blNo)
                return 3;//都存在
            else if (blName && (!blNo))
                return 1;//Name存在
            else if (!blName && blNo)
                return 2;//No存在
            else
                return 0;//都不存在
        }

        /// <summary>
        /// 添加冷库并返回编号
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <returns></returns>
        public int AddStore(StoreInfo storeInfo)
        {
            return storeDAL.AddStore(storeInfo, 1);
        }

        /// <summary>
        /// 更新冷库信息
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <returns></returns>
        public bool UpdateStore(StoreInfo storeInfo)
        {
            return storeDAL.UpdateStore(storeInfo);
        }

        public bool IsAddRegions(int storeId)
        {
            int count = storeDAL.GetStoreRegionCount(storeId);
            if (count > 0)
                return true;
            return false;
        }

        /// <summary>
        /// 逻辑删除冷库
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public int LogicDeleteStore(int storeId)
        {
            int reDel = 0;//失败
            if (IsAddRegions(storeId))
                reDel = 2;//已添加了分区
            else
            {
                bool blDel = storeDAL.Delete(storeId, 0, 1);
                if (blDel)
                    reDel = 1;//删除成功
                else
                    reDel = 0;
            }
            return reDel;
        }
        public List<StoreInfo> GetAllStores()
        {
            return storeDAL.GetAllStores();
        }
    }
}
