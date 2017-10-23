namespace ICRC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requestsDBSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        From = c.String(),
                        To = c.String(),
                        ProductType = c.String(),
                        Quantity = c.Single(nullable: false),
                        Priority = c.Int(nullable: false),
                        Notes = c.String(),
                        Treated = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RequestId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Requests");
        }
    }
}
