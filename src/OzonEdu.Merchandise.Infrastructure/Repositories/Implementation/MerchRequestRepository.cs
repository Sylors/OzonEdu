using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using OzonEdu.Merchandise.Domain.Contracts;

namespace OzonEdu.Merchandise.Infrastructure.Repositories.Implementation
{
    public class MerchRequestRepository : IMerchRequestRepository
    {
        public Task<List<MerchRequest>> GetMerchReceivedByEmployeeIdAsync(long employeeId, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        Task<long> IMerchRequestRepository.CreateAsync(MerchRequest merchRequest, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<MerchRequest>> GetAllRequestsInWorkAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        Task<MerchRequest> IRepository<MerchRequest>.CreateAsync(MerchRequest itemToCreate, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<MerchRequest> UpdateAsync(MerchRequest itemToUpdate, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}