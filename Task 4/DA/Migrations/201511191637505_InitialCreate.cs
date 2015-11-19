namespace DA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InputFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdManager = c.Int(nullable: false),
                        DateFile = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOrder = c.DateTime(nullable: false),
                        IdClient = c.Int(nullable: false),
                        Product = c.String(),
                        Cost = c.Double(nullable: false),
                        File_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InputFiles", t => t.File_Id)
                .Index(t => t.File_Id);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "File_Id", "dbo.InputFiles");
            DropIndex("dbo.Orders", new[] { "File_Id" });
            DropTable("dbo.Managers");
            DropTable("dbo.Orders");
            DropTable("dbo.InputFiles");
            DropTable("dbo.Clients");
        }
    }
}
