using System.Collections.Generic;
using OzonEdu.Merchandise.Infrastructure.Models.DTO;

namespace OzonEdu.Merchandise.Infrastructure.Queries.GetInfoAboutIssuanceMerch
{
    public class GetInfoAboutIssuanceMerchQueryResponse
    {
        public IReadOnlyCollection<MerchRequestDataDto> Items { get; set; }
    }
}