﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DMACC.CIS174.Domain;
using DMACC.CIS174.Shared.Orchestrators.Interfaces;
using DMACC.CIS174.Shared.ViewModels;
using DMACC.CIS174.Domain.Entities;

namespace DMACC.CIS174.Shared.Orchestrators
{
    public class StudentOrchestrator : IStudentOrchestrator
    {
        private SchoolContext _schoolContext;

        public StudentOrchestrator()
        {
            _schoolContext = new SchoolContext();
        }

        public async Task<int> CreateStudent(StudentViewModel student)
        {
            _schoolContext.Students.Add(new Student
            {
                StudentId = student.StudentId,
                StudentName = student.StudentName,
                Height = student.Height,
                Weight = student.Weight,
                Address = null,
                DateOfBirth = null
            });

            return await _schoolContext.SaveChangesAsync();
        }

        public async Task<List<StudentViewModel>> GetAllStudents()
        {
            var students = await _schoolContext.Students.Select(x => new StudentViewModel
            {
                StudentId = x.StudentId,
                StudentName = x.StudentName,
                Height = x.Height,
                Weight = x.Weight,
            }).ToListAsync();

            return students;
        }
    }
}
