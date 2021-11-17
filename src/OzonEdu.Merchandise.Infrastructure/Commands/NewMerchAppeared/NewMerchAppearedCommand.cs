using System.Collections.Generic;
using MediatR;

namespace OzonEdu.Merchandise.Infrastructure.Commands.NewMerchAppeared
{
    public class NewMerchAppearedCommand : IRequest<Unit>
    {
        public IReadOnlyCollection<long> SkuList { get; init; }

        public NewMerchAppearedCommand(IReadOnlyCollection<long> skuList)
        {
            SkuList = skuList;
        }
    }
}