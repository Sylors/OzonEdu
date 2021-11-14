using OzonEdu.Merchandise.Domain.Models;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchAggregate
{
    public class Merch : Entity, IAggregationRoot
    {
        public Merch(Name name, Description description, MerchType merchType, Quantity quantity)
        {
            Name = name;
            Description = description;
            MerchType = merchType;
            Quantity = quantity;
        }


        public Name Name { get; private set; }
        public Description Description { get; private set; }
        public MerchType MerchType { get; private set; }
        public Quantity Quantity { get; private set; }
    }
}