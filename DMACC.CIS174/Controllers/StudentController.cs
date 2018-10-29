using System.Threading.Tasks;
using System.Web.Mvc;
using DMACC.CIS174.Models;
using DMACC.CIS174.Shared.Orchestrators;
using System;

namespace DMACC.CIS174.Controllers
{
    public class StudentController : Controller
    {
        private StudentOrchestrator _studentOrchestrator = new StudentOrchestrator();
        // GET: Student
        public async Task<ActionResult> Index()
        {
            var studentDisplayModel = new StudentDisplayModel
            {
                Students = await _studentOrchestrator.GetAllStudents()
            };
             
            return View(studentDisplayModel);
        }
        public async Task<ActionResult> Create(CreateStudentModel student)
        {
            if(string.IsNullOrWhiteSpace(student.StudentName))
            return View();

            var updatedCount = await _studentOrchestrator.CreateStudent(new Shared.ViewModels.StudentViewModel
            {
                StudentId = Guid.NewGuid(),
                StudentName = student.StudentName,
                Height = student.Height,
                Weight = student.Weight
            });

            return View();
        }
    }
} 