using MediatR;

namespace OzonEdu.Merchandise.Infrastructure.Queries.MerchAggregate
{
    
    public class RequestMerchQuery: IRequest 
    {
        public long EmployeeId { get; init; }

        public RequestMerchQuery(long employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}