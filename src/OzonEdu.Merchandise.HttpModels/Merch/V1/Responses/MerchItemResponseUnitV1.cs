using System;

namespace OzonEdu.Merchandise.HttpModels.Merch.V1.Responses
{
    public class MerchItemResponseUnitV1
    {
        public long ItemId { get; set; }
        
        public string ItemName { get; set; }
        
        public DateTime DateOfIssue { get; set; }
    }
}