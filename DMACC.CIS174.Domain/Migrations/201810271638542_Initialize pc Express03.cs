namespace DMACC.CIS174.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializepcExpress03 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Guid(nullable: false),
                        AddressType = c.String(),
                        StreetAddress1 = c.String(),
                        StreetAddress2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.Int(nullable: false),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Guid(nullable: false),
                        StudentName = c.String(),
                        DateOfBirth = c.DateTime(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        Address_AddressId = c.Guid(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressId)
                .Index(t => t.Address_AddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Address_AddressId", "dbo.Addresses");
            DropIndex("dbo.Students", new[] { "Address_AddressId" });
            DropTable("dbo.Students");
            DropTable("dbo.Addresses");
        }
    }
}
