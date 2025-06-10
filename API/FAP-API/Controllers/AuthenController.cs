using FAP_API.ModelDTO;
using FAP_API.Models;
using FAP_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FAP_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenController(JwtToken _jwtToken, Prm392Context _prm392Context) : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginInfo loginInfor)
        {
            if(loginInfor != null)
            {
                var token = _jwtToken.GenarateToken(loginInfor);
                return Ok(new {Token = token});
            }
            return BadRequest();
        }

    }
}
