using System.Collections.Generic;
using MediatR;

namespace OzonEdu.Merchandise.Infrastructure.Commands.CreateMerchRequest
{
    public class CreateMerchRequestCommand : IRequest<Unit>
    {
        public long EmployeeId { get; init; }
        public string EmployeeEmail { get; init; }
        public string SetType { get; init; }
        public string ClothingSize { get; init; }

        public CreateMerchRequestCommand(long employeeId, string employeeEmail, string setType, string clothingSize)
        {
            EmployeeId = employeeId;
            EmployeeEmail = employeeEmail;
            SetType = setType;
            ClothingSize = clothingSize;
        }
    }
}