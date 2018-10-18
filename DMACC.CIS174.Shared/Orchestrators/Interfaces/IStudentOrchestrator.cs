using System.Collections.Generic;
using System.Threading.Tasks;
using DMACC.CIS174.Shared.ViewModels;

namespace DMACC.CIS174.Shared.Orchestrators.Interfaces
{
    interface IStudentOrchestrator
    {
        Task<List<StudentViewModel>> GetAllStudents();
    }
}
