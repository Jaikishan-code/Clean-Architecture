using CoreApp.Application.Interfaces;
using CoreApp.Application.ViewModels;
using CoreApp.Domain.Models;
using CoreApp.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<long> AddStudentAsync(Student student)
        {
            // Implement the logic to add a student here
            return  _studentRepository.Insert(student);
        }


        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            var students =  _studentRepository.GetAll();
            return students;
        }
        public StudentViewModel GetStudentById(int id)
        {
            var student = _studentRepository.Get(id);

            var studentViewModel = new StudentViewModel
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Age = student.Age,
                medium = student.medium,
            };

            return studentViewModel;
        }

        public void UpdateStudent(StudentViewModel student)
        {
            var studentToUpdate = new Student
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Age = student.Age,
                medium = student.medium,
            };
            _studentRepository.Update(studentToUpdate);
        }

        public void DeleteStudent(int id)
        {
            var student = _studentRepository.Get(id);
            _studentRepository.Delete(student);
        }

 
    }

}
