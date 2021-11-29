using System;
using System.Collections.Generic;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using Xunit;

namespace OzonEdu.Merchandise.Domain.Tests
{
    public class SkuTests
    {
        [Fact]
        public void CreateSkuItem()
        {
           var sku = Sku.Create(1);
            
           Assert.Equal(1, sku.Value);
        }
        
        [Fact]
        public void CreateSkuItemWithZeroValue()
        {
            Assert.Throws<Exception>(() => Sku.Create(0));
        }
        
        [Fact]
        public void CreateSkuItemWithNegativeValue()
        {
            Assert.Throws<Exception>(() => Sku.Create(-1));
        }
    }
}