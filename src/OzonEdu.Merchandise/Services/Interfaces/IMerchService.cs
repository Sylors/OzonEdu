using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.Merchandise.HttpModels;

namespace OzonEdu.Merchandise.Services.Interfaces
{
    public interface IMerchService
    {
        Task RequestMerch(long employeeId, CancellationToken _);

        Task<List<MerchItemResponse>> GetInformationAboutIssuanceMerch(long employeeId, CancellationToken _);
    }
}