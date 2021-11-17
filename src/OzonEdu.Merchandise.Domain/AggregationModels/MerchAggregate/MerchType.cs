using System.Collections.Generic;
using OzonEdu.Merchandise.Domain.Root;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchAggregate
{
    public class MerchType : ValueObject
    {
        public MerchItemType Value { get; }

        public MerchType(MerchItemType name)
        {
            Value = name;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}