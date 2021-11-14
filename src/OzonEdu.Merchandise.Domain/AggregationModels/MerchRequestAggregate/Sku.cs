using System.Collections.Generic;
using OzonEdu.Merchandise.Domain.Models;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    /// <summary>
    /// Артикул товара
    /// </summary>
    public sealed class Sku : ValueObject
    {
        public Sku(string name, string category, string code)
        {
            Name = name;
            Category = category;
            Code = code;
        }
        
        public string Name { get; }

        public string Category { get; }

        public string Code { get; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Category;
            yield return Code;
        }
    }
}
