using Common.CustAttributes;
using SMS.Models.DModels;


namespace SMS.Models.VModels
{
    [Table("ViewStoreRegionInfo")]
    [PrimaryKey("SRegionId")]
    public class ViewStoreRegionInfo:StoreRegionInfo
    {
        public string StoreName { get; set; }
        public string TemperStateText { get; set; }
    }
}
