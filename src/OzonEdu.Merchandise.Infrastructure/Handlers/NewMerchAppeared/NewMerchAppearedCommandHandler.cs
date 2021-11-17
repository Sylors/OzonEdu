using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OzonEdu.Merchandise.Infrastructure.Commands.NewMerchAppeared;
using OzonEdu.Merchandise.Infrastructure.Repositories;

namespace OzonEdu.Merchandise.Infrastructure.Handlers.NewMerchAppeared
{
    public class NewMerchAppearedCommandHandler : IRequestHandler<NewMerchAppearedCommand>
    {
        public readonly IMerchRequestRepository _merchRequestRepository;

        public NewMerchAppearedCommandHandler(IMerchRequestRepository merchRequestRepository)
        {
            _merchRequestRepository = merchRequestRepository;
        }

        public async Task<Unit> Handle(NewMerchAppearedCommand request, CancellationToken cancellationToken)
        {
            var allResuestInWork = await _merchRequestRepository.GetAllRequestsInWorkAsync(cancellationToken);

            allResuestInWork = allResuestInWork
                .Where(x => x.SkuSet.Items.Any(sku => request.SkuList.Contains(sku.Value)))
                .OrderBy(x => x.CreationDate).ToList();

            foreach (var merchRequest in allResuestInWork)
            {
                // TODO StockApi
                bool avalible = true;
                merchRequest.GiveOut(avalible, DateTimeOffset.UtcNow);
            }
            throw new System.NotImplementedException();
        }
    }
}