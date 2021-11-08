using OzonEdu.Merchandise.Domain.Models;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchAggregate
{
    public class Merch : Entity
    {
        public Merch(Name name, Description description, MerchType merchType, Quantity quantity)
        {
            Name = name;
            Description = description;
            MerchType = merchType;
            Quantity = quantity;
        }


        public Name Name { get; }
        public Description Description { get; }
        public MerchType MerchType { get; }
        public Quantity Quantity { get; }
    }
}