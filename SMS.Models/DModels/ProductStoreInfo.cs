using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.DModels
{
    /// <summary>
    /// 产品入库信息实体
    /// </summary>
    [Table("ProductStoreInfo")]
    [PrimaryKey("ProStoreId")]
    public  class ProductStoreInfo
    {
        public int ProStoreId { get; set; }
        public int ProductId { get; set; }
        
        public int SRegionId { get; set; }
        public int ProductCount { get; set; }
        public int IsDeleted { get; set; }
    }
}
