using MediatR;

namespace OzonEdu.Merchandise.Infrastructure.Queries.MerchRequestAggregate
{
    
    public class RequestMerchQuery: IRequest 
    {
        public long EmployeeId { get; set; }
    }
}