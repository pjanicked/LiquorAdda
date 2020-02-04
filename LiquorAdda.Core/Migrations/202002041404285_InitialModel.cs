namespace LiquorAdda.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Liquors",
                c => new
                    {
                        LiquorId = c.Int(nullable: false, identity: true),
                        LiquorName = c.String(nullable: false, maxLength: 100, unicode: false),
                        LiquorPrice = c.Double(nullable: false),
                        LiquorQuantity = c.Double(nullable: false),
                        LiquorType = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.LiquorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Liquors");
        }
    }
}
