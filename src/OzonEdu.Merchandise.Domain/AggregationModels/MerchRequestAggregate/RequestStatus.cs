using OzonEdu.Merchandise.Domain.Models;

namespace OzonEdu.Merchandise.Domain.AggregatesModels.MerchRequestAggregate
{
    public class RequestStatus : Enumeration
    {
        public static RequestStatus Draft = new(1, "Draft");
        public static RequestStatus Created = new(2, "Created");
        public static RequestStatus Assigned = new(3, "Assigned");
        public static RequestStatus InProgress = new(4, "InProgress");
        public static RequestStatus Done = new(5, "Done");

        public RequestStatus(int id, string name) : base(id, name)
        {
        }
    }
}