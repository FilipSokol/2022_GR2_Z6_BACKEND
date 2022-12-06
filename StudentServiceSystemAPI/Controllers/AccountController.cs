using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace StudentServiceSystemAPI.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("register")]
        [SwaggerOperation(Summary = "Register user")]
        public ActionResult RegisterUser([FromBody]RegisterUserDto dto)
        {
            this.accountService.RegisterUser(dto);
            return Ok();
        }

        [HttpPost("login")]
        [SwaggerOperation(Summary = "Sign in")]
        public ActionResult Login([FromBody]LoginDto dto)
        {
            string token = this.accountService.GenerateJwt(dto);
            return Ok(new { Token = token });
        }
    }
}
