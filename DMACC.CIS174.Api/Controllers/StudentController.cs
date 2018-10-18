using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using DMACC.CIS174.Shared.Orchestrators;
using DMACC.CIS174.Shared.ViewModels;

namespace DMACC.CIS174.Api.Controllers
{
    [Route("api/v1/students")]
    public class StudentController : ApiController
    {
        private StudentOrchestrator _studentOrchestrator;

        public StudentController()
        {
            _studentOrchestrator = new StudentOrchestrator();
        }

        public async Task<List<StudentViewModel>> GetAllStudents()
        {
            var students = await _studentOrchestrator.GetAllStudents();

            return students;
        }
    }
}
