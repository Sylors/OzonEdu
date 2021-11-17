using System;

namespace OzonEdu.Merchandise.Infrastructure.Models.DTO
{
    public class MerchRequestDataDto
    {

        public string Type { get; init; }

        public string Status { get; init; }
        
        public DateTimeOffset CreationDate { get; init;}
        
        public DateTimeOffset? GiveOutDate { get; init; }
    }
}