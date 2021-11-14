using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OzonEdu.Merchandise.Domain.Models;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    public sealed class SkuList : ValueObject, IEnumerable<Sku>
    {
        private List<Sku> Items { get; }

        public SkuList(IEnumerable<Sku> items)
            => Items = new List<Sku>(items);
        
        public IEnumerator<Sku> GetEnumerator()
            => Items.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
        
        /// <summary>
        /// Так как SkuList это Value object и он неизменяый,
        /// то если мы хотим добавить еще один элемент к нему
        /// необходимо создать новый SkuList
        /// </summary>
        public SkuList AddSku(string name, string category, string code)
        {
            var items = Items.ToList();
            items.Add(new Sku(name, category, code));

            return new SkuList(items);
        }
        
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Items;
        }
        
    }
}
