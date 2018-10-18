using System.Threading.Tasks;
using System.Web.Mvc;
using DMACC.CIS174.Models;
using DMACC.CIS174.Shared.Orchestrators;

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
    }
}