using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchAggregate;
using OzonEdu.Merchandise.Domain.Contracts;

namespace OzonEdu.Merchandise.Infrastructure.Repositories
{
    public interface IMerchRepository : IRepository<Merch>
    {
        Task<List<Merch>> GetMerchReceivedByEmployee(long employeeId, CancellationToken cancellationToken = default);
    }
}