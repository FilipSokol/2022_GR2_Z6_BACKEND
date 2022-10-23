using Microsoft.AspNetCore.Mvc;
using StudentServiceSystemAPI.DtoModels;
using StudentServiceSystemAPI.Services;

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
        public Task<ActionResult> RegisterUser([FromBody]RegisterUserDto dto)
        {
            throw new NotImplementedException();
        }

        [HttpPost("login")]
        public Task<ActionResult> Login([FromBody]LoginDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
