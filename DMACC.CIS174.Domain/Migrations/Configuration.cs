using DMACC.CIS174.Domain.Entities;

namespace DMACC.CIS174.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DMACC.CIS174.Domain.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DMACC.CIS174.Domain.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Students.AddOrUpdate(x => x.StudentId,
                new Student()
                {
                    StudentId = Guid.Parse("df2353d0-f6ce-40bb-acd4-5289684350ed"),
                    StudentName = "Bill Gates",
                    Height = 6.05m,
                    Weight = 167.8f
                });
        }
    }
}
