using MediatR;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate.DomainEvents
{
    public sealed record MerchRequestGiveOut: INotification
    {
        public Employee Employee { get; init; }
        
        public SkuSet SkuList { get; init; }
    }
}