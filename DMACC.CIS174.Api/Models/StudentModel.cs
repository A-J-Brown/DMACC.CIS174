using System;

namespace DMACC.CIS174.Api.Models
{
    public class StudentModel
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public AddressModel Address { get; set; }
    }
}