namespace ICRC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addclaims2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Complaints",
                c => new
                    {
                        ComplaintId = c.Int(nullable: false, identity: true),
                        From = c.String(),
                        To = c.String(),
                        Subject = c.String(),
                        Description = c.String(),
                        Priority = c.Int(nullable: false),
                        Treated = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ComplaintId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Complaints");
        }
    }
}
