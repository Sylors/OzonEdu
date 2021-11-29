using OzonEdu.Merchandise.Domain.Root;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    public class Employee : Entity
    {
        public Employee(long id, Email email,ClothingSize clothingSize)
        {
            Id = id;
            Email = email;
            ClothingSize = clothingSize;
        }

        public long Id { get; private set; }
        public Email Email { get; private set; }
        public ClothingSize ClothingSize { get; private set; }
    }
}