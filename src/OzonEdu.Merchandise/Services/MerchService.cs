using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OzonEdu.Merchandise.HttpModels;
using OzonEdu.Merchandise.Services.Interfaces;

namespace OzonEdu.Merchandise.Services
{
    public class MerchService : IMerchService
    {
        public Task RequestMerch(long employeeId, CancellationToken _)
        {
            throw new NotImplementedException();
        }

        public Task<List<MerchItemResponse>> GetInformationAboutIssuanceMerch(long employeeId, CancellationToken _)
        {
            throw new NotImplementedException();
        }
    }
}