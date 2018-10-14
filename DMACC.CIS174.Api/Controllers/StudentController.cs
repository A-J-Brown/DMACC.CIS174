using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DMACC.CIS174.Domain;
using System.Web.Http;
using DMACC.CIS174.Api.Models;

namespace DMACC.CIS174.Api.Controllers
{
    [Route("api/v1/students")]
    public class StudentController : ApiController
    {
        private SchoolContext _schoolContext;

        public StudentController()
        {
            _schoolContext = new SchoolContext();
        }

        public async Task<ICollection<StudentModel>> GetAllStudents()
        {
            var students = await _schoolContext.Students.Select(x => new StudentModel
            {
                StudentId = x.StudentId,
                StudentName = x.StudentName,
                DateOfBirth = x.DateOfBirth,
                Height = x.Height,
                Weight = x.Weight,
            }).ToListAsync();

            return students;
        }
    }
}
