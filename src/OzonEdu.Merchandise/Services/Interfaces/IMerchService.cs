using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.Merchandise.Models;

namespace OzonEdu.Merchandise.Services.Interfaces
{
    public interface IMerchService
    {
        Task RequestMerch(long employeeId, CancellationToken _);

        Task<List<MerchItemInfo>> GetInfoAboutIssuanceMerch(long employeeId, CancellationToken _);
    }
}