using CoreApp.Application.ViewModels;
using CoreApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Application.Interfaces
{
    public interface IStudentService
    {
        Task<long> AddStudentAsync(Student student);
        Task<IEnumerable<Student>> GetAllStudents();
        StudentViewModel GetStudentById(int id);
        void UpdateStudent(StudentViewModel student);
        void DeleteStudent(int id);


    }
}
