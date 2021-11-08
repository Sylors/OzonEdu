using MediatR;

namespace OzonEdu.Merchandise.Infrastructure.Queries.MerchAggregate
{
    
    public class RequestMerchQuery: IRequest <int>
    {
        public long EmployeeId { get; set; }
    }
}