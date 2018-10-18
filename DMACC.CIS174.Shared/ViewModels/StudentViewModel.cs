using System;

namespace DMACC.CIS174.Shared.ViewModels
{
    public class StudentViewModel
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public decimal Height { get; set; }
        public string HeightString => Height.ToString();
        public float Weight { get; set; }
        public string WeightString => Weight.ToString();
    }
}
