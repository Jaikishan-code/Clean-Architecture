using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Infra.Data.Interfaces
{
    public interface IRoleRepository
    {
        void AddNewRole(IdentityRole role);
    }
}
