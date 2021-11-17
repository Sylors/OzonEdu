using MediatR;

namespace OzonEdu.Merchandise.Infrastructure.Queries.GetInfoAboutIssuanceMerch
{
    
    public class GetInfoAboutIssuanceMerchQuery: IRequest<GetInfoAboutIssuanceMerchQueryResponse> 
    {
        public long EmployeeId { get; init; }

        public GetInfoAboutIssuanceMerchQuery(long employeeId)
        {
            EmployeeId = employeeId;
        }
    }
}