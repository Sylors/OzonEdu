using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Infrastructure.Commands.CreateMerchRequest;
using OzonEdu.Merchandise.Infrastructure.Repositories;

namespace OzonEdu.Merchandise.Infrastructure.Handlers.CreateMerchRequest
{
    public class CreateMerchRequestCommandHandler : IRequestHandler<CreateMerchRequestCommand>
    {
        public readonly IMerchRequestRepository _merchRequestRepository;

        public readonly ISkuSetRepository _skuSetRepository;

        public CreateMerchRequestCommandHandler(IMerchRequestRepository merchRequestRepository,
            ISkuSetRepository skuSetRepository)
        {
            _merchRequestRepository = merchRequestRepository ??
                                      throw new ArgumentNullException($"{nameof(merchRequestRepository)}");
            _skuSetRepository = skuSetRepository ??
                                throw new ArgumentNullException($"{nameof(skuSetRepository)}");
        }

        public async Task<Unit> Handle(CreateMerchRequestCommand request, CancellationToken cancellationToken)
        {
            var set = await _skuSetRepository.FindByTypeAsync(SetType.Parse(request.SetType), cancellationToken);

            var alreadyExistRequest =
                await _merchRequestRepository.GetMerchReceivedByEmployeeIdAsync(request.EmployeeId, cancellationToken);

            var merchRequest = MerchRequest.Create(
                employee: new Employee(request.EmployeeId, Email.Create(request.EmployeeEmail),
                    ClothingSize.Parse(request.ClothingSize)),
                skuList: set,
                alreadyExistedRequest: alreadyExistRequest,
                creationDate: DateTimeOffset.UtcNow
            );

            var requestId = await _merchRequestRepository.CreateAsync(merchRequest, cancellationToken);

            merchRequest = new MerchRequest(
                new RequestNumber(requestId),
                merchRequest.Status,
                merchRequest.Employee,
                123 /*TODO*/,
                merchRequest.SkuSet,
                merchRequest.CreationDate,
                merchRequest.GiveOutDate);

            // TODO StockApi
            bool avalible = true;

            merchRequest.GiveOut(avalible, DateTimeOffset.UtcNow);

            await _merchRequestRepository.UpdateAsync(merchRequest, cancellationToken);
            return Unit.Value;
        }
    }
}