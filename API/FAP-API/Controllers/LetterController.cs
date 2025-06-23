using FAP_API.Models;
using FAP_API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace FAP_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize]
    public class LetterController : ControllerBase
    {
		private readonly ILetterService _letterService;

		public LetterController(ILetterService letterService)
		{
			_letterService = letterService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Letter>> GetLetters()
		{
			var letters = _letterService.GetLetterList();
			return Ok(letters);
		}

		[HttpGet]
		public ActionResult<IEnumerable<Letter>> GetLettersByUser()
		{ 
			// Lấy UserId từ Claim
			var userId = User.FindFirst("UserId")?.Value;
			if (userId == null) return Unauthorized("User ID not found in token");

			var letters = _letterService.GetLettersByUserId(userId);
			return Ok(letters);
		}

		[HttpGet]
		public ActionResult<IEnumerable<Letter>> GetLettersByStatus(int status)
		{
			var letters = _letterService.GetLettersByStatus(status);
			return Ok(letters);
		}

		[HttpPut]
		public IActionResult UpdateStatus([FromQuery] string letterId, [FromQuery] int newStatus)
		{
			var result = _letterService.UpdateLetterStatus(letterId, newStatus);
			if (!result)
				return NotFound("Letter not found");

			return Ok("Status updated successfully");
		}

	}
}
