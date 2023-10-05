using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Application.Interfaces;
using CoreApp.Domain.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreAppDemo.MVC.ApiControllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IRoleService _roleService;

        public AuthController(IAuthService authService, IRoleService roleService)
        {
            _authService = authService;
            _roleService = roleService;
        }

        [HttpPost]
        [Route("api/register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var authResponse = await _authService.RegisterAsync(model);
            return Ok(authResponse);
        }

        [HttpPost]
        [Route("api/login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var authResponse = await _authService.LoginAsync(model);
            return Ok(authResponse);
        }

        [HttpPost]
        [Route("api/logout")]
        public async Task<IActionResult> Logout()
        {
            var authResponse = await _authService.LogoutAsync();
            return Ok(authResponse);
        }


        [HttpPost]
        [Route("api/AddRole")]
        public async Task<IActionResult> AddRole(IdentityRole role)
        {
            var authResponse =  _roleService.Add(role);
            return Ok(authResponse);
        }

    }
}