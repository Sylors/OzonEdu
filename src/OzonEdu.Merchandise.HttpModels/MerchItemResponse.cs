using System;

namespace OzonEdu.Merchandise.HttpModels
{
    public class MerchItemResponse
    {
        public long ItemId { get; set; }
        
        public string ItemName { get; set; }
        
        public DateTime DateOfIssue { get; set; }
    }
}