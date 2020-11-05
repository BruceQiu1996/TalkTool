using CloboticsTalk.Module.Core.Abstractions.Entities;
using CloboticsTalk.Module.Core.Abstractions.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClobtoticsTalk.Module.Core.Controllers
{

    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(
            UserManager<User> userManager,
            SignInManager<User> signInManager) 
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost()]
        public async Task<IActionResult> LoginByUserName(LoginViewModel model) 
        {
            if (!ModelState.IsValid)
                return BadRequest(new {message="用户信息错误"});

            var user = await _userManager.FindByNameAsync(model.UserName);
            if(user==null)
                return BadRequest(new {message = "用户不存在!" });
            if(!user.IsActive)
                return BadRequest(new { message = "用户被禁用!" });

            var signInResult=await _signInManager.PasswordSignInAsync(user,model.Password,true,true);
            if (signInResult.IsLockedOut)
            {
                return BadRequest(new { message = "用户已锁定，请稍后重试" });
            }
            else if (signInResult.IsNotAllowed)
            {
                return BadRequest(new { message = "用户邮箱未验证或手机未验证，不允许登录" });
            }
            else if (signInResult.Succeeded)
            {
                var token = await _tokenService.GenerateAccessToken(user);
                var loginResult = new LoginResult()
                {
                    Token = token,
                    Avatar = user.AvatarUrl,
                    Email = user.Email,
                    Name = user.FullName,
                    Phone = user.PhoneNumber
                };
                if (includeRefreshToken)
                {
                    var refreshToken = _tokenService.GenerateRefreshToken();
                    user.RefreshTokenHash = _userManager.PasswordHasher.HashPassword(user, refreshToken);
                    await _userManager.UpdateAsync(user);
                    loginResult.RefreshToken = refreshToken;
                }
                return Ok(loginResult);
            }
            return BadRequest( new { message = "用户登录失败，用户名或密码错误" });
        }
    }
}
