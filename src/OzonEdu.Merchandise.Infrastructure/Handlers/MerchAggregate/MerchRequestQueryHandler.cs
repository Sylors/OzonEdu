using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OzonEdu.Merchandise.Infrastructure.Queries.MerchAggregate;
using OzonEdu.Merchandise.Infrastructure.Repositories;

namespace OzonEdu.Merchandise.Infrastructure.Handlers.MerchAggregate
{
    public class MerchRequestQueryHandler : IRequestHandler<RequestMerchQuery>
    {
        public readonly IMerchRepository _merchRepository;

        public MerchRequestQueryHandler(IMerchRepository merchRepository)
        {
            _merchRepository = merchRepository ??
                               throw new ArgumentNullException($"{nameof(merchRepository)}");
        }

        public async Task<Unit> Handle(RequestMerchQuery request, CancellationToken cancellationToken)
        {
            await _merchRepository.GetMerchReceivedByEmployee(request.EmployeeId);
            return Unit.Value;
        }
    }
}