using System.Collections.Generic;
using MediatR;

namespace OzonEdu.Merchandise.Infrastructure.Commands.MerchRequestAggregate
{
    public class CreateMerchRequestCommand: IRequest  {
        public long EmployeeId { get; init; }
        
        public List<long> SkuList { get; init; }
        public CreateMerchRequestCommand(long employeeId, List<long> skuList)
        {
            EmployeeId = employeeId;
            SkuList = skuList;  
        }
    }
}