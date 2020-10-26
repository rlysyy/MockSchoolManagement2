using Microsoft.AspNetCore.Mvc;
using MockSchoolManagement.Models;

namespace MockSchoolManagement.Controllers
{
    public class HomeController:Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public string Index()
        {
            //return "Hello From MVC";
            return _studentRepository.GetStudent(1).Name;
        }

        public ViewResult Details()
        {
            Student model = _studentRepository.GetStudent(1);
            ViewBag.PageTitle = "学生详情";

            return View(model);
        }
    }
}
