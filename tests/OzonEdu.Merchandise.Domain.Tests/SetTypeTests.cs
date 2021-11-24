using System;
using System.Collections.Generic;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;
using Xunit;

namespace OzonEdu.Merchandise.Domain.Tests
{
    public class SetTypeTests
    {
        [Fact]
        public void SetTypeParseUnknownPack()
        {
            Assert.Throws<Exception>(() => SetType.Parse("Unknown-pack"));
        }
        
        [Fact]
        public void CrateNewTypeWithZeroId()
        {
            Assert.Throws<Exception>(() => new SetType(0, "new-pack"));
        }
        
        [Fact]
        public void CrateNewTypeWithNegativeId()
        {
            Assert.Throws<Exception>(() => new SetType(-1, "new-pack"));
        }
        
    }
}