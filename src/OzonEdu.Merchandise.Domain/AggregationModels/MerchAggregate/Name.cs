using System.Collections.Generic;
using OzonEdu.Merchandise.Domain.Models;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchAggregate
{
    public class Name : ValueObject
    {
        public string Value { get; }

        public Name(string name)
        {
            Value = name;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}