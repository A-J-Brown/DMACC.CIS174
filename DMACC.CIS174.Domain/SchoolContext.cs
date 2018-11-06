using System.Data.Entity;
using DMACC.CIS174.Domain.Entities;

namespace DMACC.CIS174.Domain
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
