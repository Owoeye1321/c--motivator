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
		public MotivatorController()
		{
		}
		[HttpGet("/quote")]
        public async IActionResult GetAllQuote()
        {
			try {

			} catch(ErrorHelper Ex)
			{
				return BadRequest(new { code = System.Net.HttpStatusCode.BadRequest, message = Ex.Message });
			}
        }
    }
}

