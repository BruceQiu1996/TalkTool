using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChatAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        } 

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task Login()
        {
            
        }
    }
}
