using Common;
using DAL.Common;
using DbUtility;
using SMS.Models.DModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DAL
{
    public class StoreDAL : BaseDAL<StoreInfo>
    {

        /// <summary>
        /// 条件查询仓库信息列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="isDel"></param>
        /// <returns></returns>
        public List<StoreInfo> GetStoreInfos(string keywords, int isDeleted)
        {
            string cols = CreateSql.GetColsString<StoreInfo>("IsDeleted");
            string strWhere = $"IsDeleted={isDeleted}";
            if (!string.IsNullOrEmpty(keywords))
            {
                strWhere += " and (StoreNo like @keywords or StoreName like @keywords) ";
                SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
                return GetModelList(strWhere, cols, para);
            }
            return GetModelList(strWhere, cols);
        }


        /// <summary>
        /// 根据id获取指定的仓库信息
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public StoreInfo GetStore(int storeId)
        {
            //string cols = "StoreNo,StoreName,Remark";
            string cols = CreateSql.GetColsString<StoreInfo>("IsDeleted");
            return GetById(storeId, cols);
        }


        /// <summary>
        /// 检查编码或名称是否已存在
        /// </summary>
        /// <param name="storeName"></param>
        /// <param name="storeNo"></param>
        /// <returns></returns>
        public bool[] ExistsStore(string storeName, string storeNo)
        {
            bool blName = false;
            if (!string.IsNullOrEmpty(storeName))
                blName = ExistsByName("StoreName", storeName);
            bool blNo = false;
            if (!string.IsNullOrEmpty(storeNo))
                blNo = ExistsByName("StoreNo", storeNo);
            return new bool[] { blName, blNo };
        }

        /// <summary>
        /// 添加冷库信息
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <param name="IsGetId">0 不返回 1 返回   id</param>
        /// <returns></returns>
        public int AddStore(StoreInfo storeInfo, int IsGetId)
        {
            string cols = "StoreName,StoreNo,Remark";
            return Add(storeInfo, cols, IsGetId);
        }

        /// <summary>
        /// 更新冷库信息
        /// </summary>
        /// <param name="storeInfo"></param>
        /// <returns></returns>
        public bool UpdateStore(StoreInfo storeInfo)
        {
            string cols = CreateSql.GetColsString<StoreInfo>("RegionCount,IsDeleted");
            return Update(storeInfo, cols);
        }

        /// <summary>
        /// 根据id获取冷库分区数
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        public int GetStoreRegionCount(int storeId)
        {
            string sql = $"select RegionCount from StoreInfo where StoreId={storeId}";
            object Count = SqlHelper.ExecuteScalar(sql, 1);
            if (Count != null && Count.ToString() != "")
                return Count.GetInt();
            return 0;
        }


      

        /// <summary>
        /// 获取所有仓库列表  下拉框
        /// </summary>
        /// <returns></returns>
        public List<StoreInfo> GetAllStores()
        {
            return GetModelList("StoreId,StoreName", 0);
        }

      
 
    }
}
