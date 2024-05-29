using Common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.DModels
{
    /// <summary>
    /// 产品信息实体
    /// </summary>
    [Table("ProductInfo")]
    [PrimaryKey("ProductId")]
    public  class ProductInfo
    {
        public int ProductId { get; set; }
        public string ProductNo { get; set; }
        public string ProductName { get; set; }
        [Column("FitLowTemperature")]
        public decimal? FitLowTemper { get; set; }
        [Column("FitHighTemperature")]
        public decimal? FitHighTemper { get; set; }
        public int IsDeleted { get; set; }
    }
}
