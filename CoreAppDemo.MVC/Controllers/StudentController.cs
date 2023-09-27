using CoreApp.Application.Interfaces;
using CoreApp.Application.ViewModels;

using CoreApp.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppDemo.MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [Authorize(Policy = "readonlypolicy")]
        public async Task<IActionResult> Index()
        {
            // Await the task to get the list of students
            var students = await _studentService.GetAllStudents();

            // Now, you can use LINQ methods like Select
            var studentViewModels = students.Select(s => new StudentViewModel
            {
                Id = s.Id,
                FirstName = s.FirstName,
                LastName = s.LastName,
                Age = s.Age,
                medium = s.medium,
            });

            return View(studentViewModels);
        }

        [Authorize(Policy = "readonlypolicy")]

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Policy = "readonlypolicy")]
        [HttpPost]
        public IActionResult Create(StudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Map ViewModel to domain model
                var student = new Student
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Age= model.Age,
                    medium = model.medium,
                };
                _studentService.AddStudentAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [Authorize(Policy = "readonlypolicy")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Fetch the student by ID and display an edit form
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound(); // Student not found
            }

            return View(student);
        }

        [Authorize(Policy = "readonlypolicy")]
        [HttpPost]
        public IActionResult Edit(StudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                _studentService.UpdateStudent(model); 
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }


       

        [HttpPost]
        public IActionResult Delete(int id)
        {
            // Call the service to delete the student
            _studentService.DeleteStudent(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
