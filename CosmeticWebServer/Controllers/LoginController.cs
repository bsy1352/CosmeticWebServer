using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CosmeticWebServer.Models.DBModels;
using CosmeticWebServer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CosmeticWebServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private grancoContext _Db;
        private static Users user { get; set; }
        public LoginController(grancoContext context)
        {
            _Db = context;
        }

        [HttpGet]
        public async Task<IActionResult> OnGetUser()
        {
            return Json(user);
        }

        [HttpPost]
        public async Task<IActionResult> OnPostTryLogin(LoginData account)
        {
            user = await _Db.Users.FirstOrDefaultAsync<Users>(u => u.UserId.Equals(account.UserId) &&
                                                                   u.UserPw.Equals(account.UserPw));

            if (user != null)
            {
                return StatusCode(200);
            }
            else
            {
                return BadRequest("로그인 정보가 일치하지 않습니다.");
            }

            
        }
    }
}
