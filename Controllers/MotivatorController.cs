using System;
using LiftDepression.Helpers;
using Microsoft.AspNetCore.Mvc;
using LiftDepression.Service;
using LiftDepression.Interface;

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
				return Ok(new { code = System.Net.HttpStatusCode.OK, message = "success", data = result });

			} catch(ErrorHelper Ex)
			{
				return BadRequest(new { code = System.Net.HttpStatusCode.BadRequest, message = Ex.Message });
			}
        }
    }
}

