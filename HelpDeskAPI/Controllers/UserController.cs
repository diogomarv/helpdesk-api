using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDeskAPI.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok("Usuário retornado!");
        }
    }
}
