﻿using System;
using LiftDepression.Helpers;
using Microsoft.AspNetCore.Mvc;
using LiftDepression.Service;
using LiftDepression.Interface;
using System.Net;

namespace LiftDepression.Controllers
{
	[ApiController]
	[Route("lift-depression")]
	public class MotivatorController : ControllerBase
	{
		private IMotivatorAction _quoteService;
		public MotivatorController(IMotivatorAction _quoteService)
		{
			this._quoteService = _quoteService;

		}
		[HttpGet("/quote")]
        public async Task<IActionResult> GetAllQuote()
        {
			try {
				IEnumerable<IGetMotivationResponse> result = await _quoteService.GetAllQuotes();
                AllQuoteResponseData response = new AllQuoteResponseData { Code = HttpStatusCode.OK, Message = "success", Data = result };

                return Ok(response);

			} catch(ErrorHelper Ex)
			{
				return BadRequest(new { code = HttpStatusCode.BadRequest, message = Ex.Message });
			}
        }

		[HttpGet("/quote/{id}")]
		public async Task<IActionResult> GetSingleQuote(singleQuoteRequest id)
		{
			try {
				IGetMotivationResponse result = await _quoteService.GetSingleQuote(id);
				SingleQuoteResponse response = new SingleQuoteResponse
				{
					Code = HttpStatusCode.OK,
					Message = "success",
					Data = result
				};

				return Ok(response);
            }
            catch(ErrorHelper Ex)
			{
				return BadRequest(new { code = HttpStatusCode.BadRequest, message = Ex.Message });
			};
		}
    }
}

