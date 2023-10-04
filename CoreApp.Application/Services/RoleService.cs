using Azure;
using CoreApp.Application.Interfaces;
using CoreApp.Application.ViewModels;
using CoreApp.Infra.Data.Interfaces;
using CoreApp.Infra.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Application.Services
{
    public class RoleService : IRoleService
    {
        IRoleRepository _roleRepository;
        public ApiResponseModel response = new ApiResponseModel();
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public ApiResponseModel Add(IdentityRole role)
        {
            try
            {
                _roleRepository.AddNewRole(role);
                if (1 < 0)
                {
                    response.Status = false;
                    response.Message = "Something Went Wrong";
                    return response;
                }
                response.Status = true;
                response.Message = "Role Added Successfully !";
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
    }
}
