using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.Contracts;

namespace OzonEdu.Merchandise.Infrastructure.Repositories
{
    public interface IMerchRequestRepository : IRepository<MerchRequest>
    {
        Task<List<MerchRequest>> GetMerchReceivedByEmployeeIdAsync(long employeeId, CancellationToken cancellationToken = default);

        Task<long> CreateAsync(MerchRequest merchRequest, CancellationToken cancellationToken);

        Task<List<MerchRequest>> GetAllRequestsInWorkAsync(CancellationToken cancellationToken);
    }
}