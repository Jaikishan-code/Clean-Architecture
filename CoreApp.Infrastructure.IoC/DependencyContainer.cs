using CoreApp.Application.Interfaces;
using CoreApp.Application.Services;
using CoreApp.Infra.Data.Interfaces;
using CoreApp.Infra.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace CoreApp.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddTransient<IBookService, BookService>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddTransient<IBookRepository, BookRepository>();

            services.AddTransient<IAuthService, AuthService>();

            services.AddTransient<IAuthRepository, AuthRepository>();

            services.AddTransient<IBookCategoryRepository,BookCategoryRepository>();

            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IStudentRepository, StudentRepository>();
            
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            
        }
    }
}
