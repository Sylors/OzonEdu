using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OzonEdu.Merchandise.HttpModels;
using OzonEdu.Merchandise.HttpModels.Merch.V1.Requests;
using OzonEdu.Merchandise.HttpModels.Merch.V1.Responses;
using OzonEdu.Merchandise.Services.Interfaces;

namespace OzonEdu.Merchandise.Controllers.V1
{
    [ApiController]
    [Route("v1/api/merch")]
    [Produces("application/json")]
    public class MerchController : ControllerBase
    {
        private readonly IMerchService _merchService;

        public MerchController(IMerchService merchService)
        {
            _merchService = merchService;
        }

        [HttpPost("request-merch")]
        public async Task<IActionResult> RequestMerch(MerchRequestV1 merchRequest, CancellationToken token)
        {
            await _merchService.RequestMerch(merchRequest.EmployeeId, token);
            return Ok();
        }
        
        [HttpGet("get-info-about-issuance-merch")]
        public async Task<ActionResult<MerchItemResponseV1>> GetInfoAboutIssuanceMerch(long employeeId,
            CancellationToken token)
        {
            var result = await _merchService.GetInfoAboutIssuanceMerch(employeeId, token);
            return Ok(result);
        }
    }
}