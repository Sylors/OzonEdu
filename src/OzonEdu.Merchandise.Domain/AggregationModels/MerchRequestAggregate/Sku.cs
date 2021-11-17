using System;
using System.Collections.Generic;
using OzonEdu.Merchandise.Domain.Root;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    /// <summary>
    /// Артикул товара
    /// </summary>
    public sealed class Sku : ValueObject
    {
        public long Value { get; }
        
        private Sku(long value)
        {
            Value = value;
        }

        public static Sku Create(long skuValue)
        {
            if (skuValue <= 0)
            {
                throw new  Exception($"Sku value is invalid: {skuValue}");
            }

            return new Sku(skuValue);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;

        }
    }
}
