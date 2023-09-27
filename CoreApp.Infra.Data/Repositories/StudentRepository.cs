using CoreApp.Domain.Models;
using CoreApp.Infra.Data.Context;
using CoreApp.Infra.Data.Interfaces;
using CoreApp.Infra.Data.RepositoryAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Infra.Data.Repositories
{
    public class StudentRepository : RepositoryAccess<Student>, IStudentRepository
    {
        private readonly LibraryDbContext _dbContext;

        public StudentRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }

}
