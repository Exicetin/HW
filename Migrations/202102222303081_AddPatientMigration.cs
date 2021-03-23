namespace HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Name = c.String(),
                        Middle_name = c.String(),
                        MainDiagnosis = c.String(),
                        AdditionalDiagnosis = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
        }
    }
}
