using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OzonEdu.Merchandise.HttpModels;
using OzonEdu.Merchandise.Services.Interfaces;

namespace OzonEdu.Merchandise.Controllers
{
    [ApiController]
    [Route("v1/api/merch/[action]")]
    public class MerchController : ControllerBase
    {
        private readonly IMerchService _merchService;

        public MerchController(IMerchService merchService)
        {
            _merchService = merchService;
        }

        [HttpPost("{employeeId:long}")]
        public async Task<IActionResult> RequestMerch(long employeeId, CancellationToken token)
        {
            await _merchService.RequestMerch(employeeId,token);
            return Ok();
        }

        [HttpGet("{employeeId:long}")]
        public async Task<ActionResult<List<MerchItemResponse>>> GetInformationAboutIssuanceMerch(long employeeId, CancellationToken token)
        {
            var result = await _merchService.GetInformationAboutIssuanceMerch(employeeId, token);
            return Ok(result);
        }
    }
}