using System.Threading;
using System.Threading.Tasks;

namespace OzonEdu.Merchandise.Domain.Contracts
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default);
    }
}