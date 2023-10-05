using CoreApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Infra.Data.Interfaces
{
    public interface IAuthRepository
    {
        Task<AuthResponse> RegisterAsync(RegisterModel Model);

        Task<AuthResponse> LoginAsync(LoginModel Model);

        Task<AuthResponse> LogoutAsync();
    }
}
