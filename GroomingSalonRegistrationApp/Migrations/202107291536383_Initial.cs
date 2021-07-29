namespace GroomingSalonRegistrationApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        HomeAddress = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        PetId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Breed = c.String(),
                        Age = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PetId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pets");
            DropTable("dbo.Customers");
        }
    }
}
