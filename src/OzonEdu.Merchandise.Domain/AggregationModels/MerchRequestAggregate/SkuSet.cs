using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using OzonEdu.Merchandise.Domain.Root;

namespace OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate
{
    public sealed class SkuSet : Entity
    {
        public IReadOnlyCollection<Sku> Items { get; private set; }
        
        public SetType Type { get; private set; }

        public SkuSet(long id, IReadOnlyCollection<Sku> skuCollection, SetType type)
        {
            Id = id;
            Items = skuCollection;
            Type = type;
        }

        public void AddSkuTolist(IReadOnlyCollection<Sku> skuCollection)
        {
            var intersect = Items.Select(x => x.Value).Intersect(skuCollection.Select(x => x.Value));
            if (intersect.Any())
            {
                throw new Exception($"Sku with ids {string.Join(", ", intersect)} already added");
            }

            Items = Items.Union(skuCollection).ToList();
        }
        
        public void DeletedSkuFromList(IReadOnlyCollection<Sku> skuCollection)
        {
            var except = skuCollection.Select(x => x.Value).Except(Items.Select(x => x.Value));
            if (except.Any())
            {
                throw new Exception($"Sku with ids {string.Join(", ", except)} not exist");
            }

            Items = Items.Except(skuCollection).ToList();
        }
        
 
        
    }
}
