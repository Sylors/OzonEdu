using System;
using System.Collections.Generic;
using Xunit;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;

namespace OzonEdu.Merchandise.Domain.Tests
{
    public class ClothingSizeTests
    {
        [Fact]
        public void ParseUnknownSize()
        {
            Assert.Throws<Exception>(() => ClothingSize.Parse("ZZ"));
        }

        [Fact]
        public void ParseXSSize()
        {
            Assert.Equal(ClothingSize.XS, ClothingSize.Parse("XS"));
        }
        
        [Fact]
        public void ParseSSize()
        {
            Assert.Equal(ClothingSize.S, ClothingSize.Parse("S"));
        }
        
        [Fact]
        public void ParseMSize()
        {
            Assert.Equal(ClothingSize.M, ClothingSize.Parse("M"));
        }
        
        [Fact]
        public void ParseLSize()
        {
            Assert.Equal(ClothingSize.L, ClothingSize.Parse("L"));
        }
        
        [Fact]
        public void ParseXLSize()
        {
            Assert.Equal(ClothingSize.XL, ClothingSize.Parse("XL"));
        }
        
        [Fact]
        public void ParseXXLSize()
        {
            Assert.Equal(ClothingSize.XXL, ClothingSize.Parse("XXL"));
        }
        
        [Fact]
        public void ParseXSSizeLowerCase()
        {
            Assert.Equal(ClothingSize.XS, ClothingSize.Parse("xs"));
        }
        
        [Fact]
        public void ParseSSizeLowerCase()
        {
            Assert.Equal(ClothingSize.S, ClothingSize.Parse("s"));
        }
        
        [Fact]
        public void ParseMSizeLowerCase()
        {
            Assert.Equal(ClothingSize.M, ClothingSize.Parse("m"));
        }
        
        [Fact]
        public void ParseLSizeLowerCase()
        {
            Assert.Equal(ClothingSize.L, ClothingSize.Parse("l"));
        }
        
        [Fact]
        public void ParseXLSizeLowerCase()
        {
            Assert.Equal(ClothingSize.XL, ClothingSize.Parse("xl"));
        }
        
        [Fact]
        public void ParseXXLSizeLowerCase()
        {
            Assert.Equal(ClothingSize.XXL, ClothingSize.Parse("xxl"));
        }
        
    }
}