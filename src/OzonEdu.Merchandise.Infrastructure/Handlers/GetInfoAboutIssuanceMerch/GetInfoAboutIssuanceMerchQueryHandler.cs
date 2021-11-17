using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OzonEdu.Merchandise.Infrastructure.Models.DTO;
using OzonEdu.Merchandise.Infrastructure.Queries.GetInfoAboutIssuanceMerch;
using OzonEdu.Merchandise.Infrastructure.Repositories;

namespace OzonEdu.Merchandise.Infrastructure.Handlers.GetInfoAboutIssuanceMerch
{
    public class GetInfoAboutIssuanceMerchQueryHandler : IRequestHandler<GetInfoAboutIssuanceMerchQuery,
        GetInfoAboutIssuanceMerchQueryResponse>
    {
        public readonly IMerchRequestRepository _merchRequestRepository;

        public GetInfoAboutIssuanceMerchQueryHandler(IMerchRequestRepository merchRequestRepository)
        {
            _merchRequestRepository = merchRequestRepository ??
                                      throw new ArgumentNullException($"{nameof(merchRequestRepository)}");
        }

        public async Task<GetInfoAboutIssuanceMerchQueryResponse> Handle(GetInfoAboutIssuanceMerchQuery request,
            CancellationToken cancellationToken)
        {
            var requests = await _merchRequestRepository.GetMerchReceivedByEmployeeIdAsync(request.EmployeeId);
            return new GetInfoAboutIssuanceMerchQueryResponse
            {
                Items = requests.Select(x => new MerchRequestDataDto
                {
                    Status = x.Status.Name,
                    CreationDate = x.CreationDate,
                    Type = x.SkuSet.Type.Name,
                    GiveOutDate = x.GiveOutDate
                }).ToList()
            };
        }
    }
}