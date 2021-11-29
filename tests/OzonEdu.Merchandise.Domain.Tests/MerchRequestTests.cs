using System;
using System.Collections.Generic;
using Xunit;
using OzonEdu.Merchandise.Domain.AggregationModels;
using OzonEdu.Merchandise.Domain.AggregationModels.MerchRequestAggregate;

namespace OzonEdu.Merchandise.Domain.Tests
{
    public class MerchRequestTests
    {
        // [Fact]
        // public void DraftMerchRequestEqualState()
        // {
        //     MerchRequest request = new MerchRequest();
        //     Assert.Equal(RequestStatus.Draft, request.Status);
        // }
        //
        // [Fact]
        // public void CreateMerchRequestEqualState()
        // {
        //     MerchRequest request = new MerchRequest();
        //     request.Create(0);
        //     Assert.Equal(RequestStatus.Created, request.Status);
        // }
        //
        // [Fact]
        // public void CreateMerchRequestNotEqualState()
        // {
        //     MerchRequest request = new MerchRequest();
        //     Assert.NotEqual(RequestStatus.Created, request.Status);
        // }
        //
        // [Fact]
        // public void AssignToMerchRequestEqualState()
        // {
        //     MerchRequest request = new MerchRequest(12);
        //     request.AssignTo(13);
        //     Assert.Equal(RequestStatus.Assigned, request.Status);
        // }
        //
        // [Fact]
        // public void AssignToMerchRequestNotEqualState()
        // {
        //     MerchRequest request = new MerchRequest();
        //     Assert.Throws<Exception>(() => request.AssignTo(13));
        // }
        //
        // [Fact]
        // public void StartWorkMerchRequestEqualState()
        // {
        //     MerchRequest request = new MerchRequest(12, 13);
        //     request.StartWork(new SkuList(new List<Sku>()));
        //     Assert.Equal(RequestStatus.InProgress, request.Status);
        // }
        //
        // [Fact]
        // public void StartWorkMerchRequestNotEqualState()
        // {
        //     MerchRequest request = new MerchRequest(12);
        //     Assert.Throws<Exception>(() => request.StartWork(new SkuList(new List<Sku>())));
        // }
        //
        // [Fact]
        // public void CompleteMerchRequestEqualState()
        // {
        //     MerchRequest request = new MerchRequest(12, 13, new SkuList(new List<Sku>()));
        //     request.Complete();
        //     Assert.Equal(RequestStatus.Done, request.Status);
        // }
        //
        // [Fact]
        // public void CompleteMerchRequestNotEqualState()
        // {
        //     MerchRequest request = new MerchRequest(12, 13);
        //     Assert.Throws<Exception>(() => request.Complete());
        // }
        
    }
}