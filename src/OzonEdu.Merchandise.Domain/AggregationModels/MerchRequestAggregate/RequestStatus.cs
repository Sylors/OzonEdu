using OzonEdu.Merchandise.Domain.Root;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    public class RequestStatus : Enumeration
    {
        public static RequestStatus Created = new(1, "Created");
        public static RequestStatus InWork = new(2, "InWork");
        public static RequestStatus Done = new(3, "Done");
        public static RequestStatus Declined = new(4, "Declined");
        public RequestStatus(int id, string name) : base(id, name)
        {
        }
    }
}