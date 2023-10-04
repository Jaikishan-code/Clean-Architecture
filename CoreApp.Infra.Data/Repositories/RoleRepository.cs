using CoreApp.Infra.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Infra.Data.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        RoleManager<IdentityRole> _roleManager;

        public RoleRepository(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public void AddNewRole(IdentityRole role)
        {
            try
            {
                var res = _roleManager.CreateAsync(role).Result;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
