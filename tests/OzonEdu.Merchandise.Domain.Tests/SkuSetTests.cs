using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using Xunit;

namespace OzonEdu.Merchandise.Domain.Tests
{
    public class SkuSetTests
    {
        [Fact]
        public void AddSkuTolistWithNewSkus()
        {
            SkuSet set = new SkuSet(123, new Collection<Sku> {Sku.Create(1), Sku.Create(2), Sku.Create(3)},
                SetType.StarterPack);
            set.AddSkuTolist(new Collection<Sku> {Sku.Create(4), Sku.Create(5)});
            Assert.Equal(5, set.Items.Count);
        }

        [Fact]
        public void AddSkuTolistWithduplicateSkus()
        {
            SkuSet set = new SkuSet(123, new Collection<Sku> {Sku.Create(1), Sku.Create(2), Sku.Create(3)},
                SetType.StarterPack);
            Assert.Throws<Exception>(() => set.AddSkuTolist(new Collection<Sku> {Sku.Create(3), Sku.Create(4)}));
        }

        [Fact]
        public void DeleteSkuFromlistContained()
        {
            SkuSet set = new SkuSet(123, new Collection<Sku> {Sku.Create(1), Sku.Create(2), Sku.Create(3)},
                SetType.StarterPack);
            set.DeletedSkuFromList(new Collection<Sku> {Sku.Create(1), Sku.Create(3)});
            Assert.Equal(1, set.Items.Count);
        }

        [Fact]
        public void DeleteSkuFromlistNotContained()
        {
            SkuSet set = new SkuSet(123, new Collection<Sku> {Sku.Create(1), Sku.Create(2), Sku.Create(3)},
                SetType.StarterPack);
            Assert.Throws<Exception>(() => set.DeletedSkuFromList(new Collection<Sku> {Sku.Create(4)}));
        }
    }
}