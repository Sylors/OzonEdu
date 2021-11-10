using System.Collections.Generic;

namespace OzonEdu.Merchandise.HttpModels.Merch.V1.Requests
{
    public class V1MerchRequest
    {
        public long EmployeeId { get; set; }
        
        public List<long> SkuList { get; set; }
    }
}