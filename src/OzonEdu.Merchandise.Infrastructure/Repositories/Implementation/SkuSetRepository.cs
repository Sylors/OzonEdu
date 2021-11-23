using System.Threading;
using System.Threading.Tasks;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.Contracts;

namespace OzonEdu.Merchandise.Infrastructure.Repositories.Implementation
{
    public class SkuSetRepository : ISkuSetRepository
    {
        public Task<SkuSet> CreateAsync(SkuSet itemToCreate, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<SkuSet> UpdateAsync(SkuSet itemToUpdate, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task SaveAsync(SkuSet skuSet, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<SkuSet> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<SkuSet> FindByTypeAsync(SetType setType, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}