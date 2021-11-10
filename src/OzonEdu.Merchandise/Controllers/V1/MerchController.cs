using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OzonEdu.Merchandise.HttpModels;
using OzonEdu.Merchandise.HttpModels.Merch.V1.Requests;
using OzonEdu.Merchandise.HttpModels.Merch.V1.Responses;
using OzonEdu.Merchandise.Infrastructure.Commands.MerchRequestAggregate;
using OzonEdu.Merchandise.Infrastructure.Queries.MerchRequestAggregate;
using OzonEdu.Merchandise.Services.Interfaces;

namespace OzonEdu.Merchandise.Controllers.V1
{
    [ApiController]
    [Route("v1/api/merch")]
    [Produces("application/json")]
    public class MerchController : ControllerBase
    {
        private readonly IMerchService _merchService;
        private readonly IMediator _mediator;

        public MerchController(IMerchService merchService, IMediator mediator)
        {
            _merchService = merchService;
            _mediator = mediator;
        }

        [HttpPost("request-merch")]
        public async Task<IActionResult> RequestMerch(V1MerchRequest merchRequest, CancellationToken token)
        {
            //await _merchService.RequestMerch(merchRequest.EmployeeId, token);

            var createMerchRequestCommand = new CreateMerchRequestCommand()
            {
                EmployeeId = merchRequest.EmployeeId,
                SkuList = merchRequest.SkuList
            };

            var result = await _mediator.Send(createMerchRequestCommand, token);
            return Ok();
        }
        
        [HttpGet("get-info-about-issuance-merch")]
        public async Task<ActionResult<V1MerchItemResponse>> GetInfoAboutIssuanceMerch(long employeeId,
            CancellationToken token)
        {
            //var result = await _merchService.GetInfoAboutIssuanceMerch(employeeId, token);
            var query = new RequestMerchQuery()
            {
                EmployeeId = employeeId
            };
            
            var result = await _mediator.Send(query, token);
            return Ok(result);
        }
    }
}