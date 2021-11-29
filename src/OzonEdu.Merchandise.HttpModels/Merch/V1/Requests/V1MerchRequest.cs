using System.Collections.Generic;

namespace OzonEdu.Merchandise.HttpModels.Merch.V1.Requests
{
    public class V1MerchRequest
    {
        public long EmployeeId { get; set; }
        public string EmployeeEmail { get; set; }
        
        public string MerchSetType { get; set; }
        public string ClothingSize { get; set; }
    }
}