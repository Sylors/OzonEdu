using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.Contracts;

namespace OzonEdu.Merchandise.Infrastructure.Repositories
{
    public interface IMerchRequestRepository : IRepository<MerchRequest>
    {
    }
}