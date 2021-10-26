using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using OzonEdu.Merchandise.Grpc;
using OzonEdu.Merchandise.Services.Interfaces;

namespace OzonEdu.Merchandise.GrpsServices
{
    public class MerchGrpsService : MerchGrpc.MerchGrpcBase
    {
        private readonly IMerchService _merchService;

        public MerchGrpsService(IMerchService merchService)
        {
            _merchService = merchService;
        }

        public override async Task<Empty> RequestMerch(RequestMerchRequest request, ServerCallContext context)
        {
            await _merchService.RequestMerch(request.EmployeeId, context.CancellationToken);
            return null;
        }

        public override async Task<GetInformationAboutIssuanceMerchReponse> GetInformationAboutIssuanceMerch(
            GetInformationAboutIssuanceMerchRequest request, ServerCallContext context)
        {
            var merchItems =
                await _merchService.GetInformationAboutIssuanceMerch(request.EmployeeId, context.CancellationToken);
            return new GetInformationAboutIssuanceMerchReponse
            {
                Merchs =
                {
                    merchItems.Select(x => new GetInformationAboutIssuanceMerchReponseUnit()
                    {
                        ItemId = x.ItemId,
                        ItemName = x.ItemName,
                        DateOfIssue = Timestamp.FromDateTime(x.DateOfIssue)
                    })
                }
            };
        }
    }
}