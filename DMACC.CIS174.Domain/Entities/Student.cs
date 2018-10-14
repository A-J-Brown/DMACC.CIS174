using System;
using System.Net.Sockets;

namespace DMACC.CIS174.Domain.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public Address Address { get; set; }
    }
}
