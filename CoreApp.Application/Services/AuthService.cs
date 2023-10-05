using CoreApp.Application.Interfaces;
using CoreApp.Application.ViewModels;
using CoreApp.Domain.Models;
using CoreApp.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Application.Services
{
    public class AuthService : IAuthService
    {

        public IAuthRepository _authRepository;
        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<AuthResponse> RegisterAsync(RegisterModel Model)
        {
            var response = await _authRepository.RegisterAsync(Model);
            return response;
        }

        public async Task<AuthResponse> LoginAsync(LoginModel model)
        {
            var response = await _authRepository.LoginAsync(model);
            return response;
        }

        public async Task<AuthResponse> LogoutAsync()
        {
            var response = await _authRepository.LogoutAsync();
            return response;
        }

    }
}
