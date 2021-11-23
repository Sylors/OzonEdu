using System.Threading;
using System.Threading.Tasks;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.Contracts;

namespace OzonEdu.Merchandise.Infrastructure.Repositories
{
    public interface ISkuSetRepository: IRepository<SkuSet>
    {
        Task SaveAsync(SkuSet skuSet, CancellationToken cancellationToken);

        Task<SkuSet> GetByIdAsync(long id, CancellationToken cancellationToken);

        Task<SkuSet> FindByTypeAsync(SetType setType, CancellationToken cancellationToken);
    }
}