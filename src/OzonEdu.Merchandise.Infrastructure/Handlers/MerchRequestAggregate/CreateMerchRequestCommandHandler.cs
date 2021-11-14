using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Infrastructure.Commands.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Infrastructure.Repositories;

namespace OzonEdu.Merchandise.Infrastructure.Handlers.MerchRequestAggregate
{
    public class CreateMerchRequestCommandHandler : IRequestHandler<CreateMerchRequestCommand>
    {
        public readonly IMerchRequestRepository _merchRequestRepository;

        public CreateMerchRequestCommandHandler(IMerchRequestRepository merchRequestRepository)
        {
            _merchRequestRepository = merchRequestRepository ??
                                      throw new ArgumentNullException($"{nameof(merchRequestRepository)}");
        }

        public async Task<Unit> Handle(CreateMerchRequestCommand request, CancellationToken cancellationToken)
        {
            var merchRequest = new MerchRequest(
                request.EmployeeId,
                123,
                new SkuList(new List<Sku>()) // TODO
            );

            await _merchRequestRepository.CreateAsync(merchRequest, cancellationToken);
            await _merchRequestRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}