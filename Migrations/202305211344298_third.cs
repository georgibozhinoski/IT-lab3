namespace lab3._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "Hospital_Id", "dbo.Hospitals");
            DropIndex("dbo.Doctors", new[] { "Hospital_Id" });
            CreateTable(
                "dbo.HospitalDoctors",
                c => new
                    {
                        Hospital_Id = c.Int(nullable: false),
                        Doctor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Hospital_Id, t.Doctor_Id })
                .ForeignKey("dbo.Hospitals", t => t.Hospital_Id, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id, cascadeDelete: true)
                .Index(t => t.Hospital_Id)
                .Index(t => t.Doctor_Id);
            
            AddColumn("dbo.Doctors", "HospitalId", c => c.Int(nullable: false));
            DropColumn("dbo.Doctors", "Hospital_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "Hospital_Id", c => c.Int());
            DropForeignKey("dbo.HospitalDoctors", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.HospitalDoctors", "Hospital_Id", "dbo.Hospitals");
            DropIndex("dbo.HospitalDoctors", new[] { "Doctor_Id" });
            DropIndex("dbo.HospitalDoctors", new[] { "Hospital_Id" });
            DropColumn("dbo.Doctors", "HospitalId");
            DropTable("dbo.HospitalDoctors");
            CreateIndex("dbo.Doctors", "Hospital_Id");
            AddForeignKey("dbo.Doctors", "Hospital_Id", "dbo.Hospitals", "Id");
        }
    }
}
