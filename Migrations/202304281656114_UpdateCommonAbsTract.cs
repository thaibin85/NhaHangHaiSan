namespace NhaHangHaiSan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCommonAbsTract : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Adv", "ModifidedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Category", "ModifidedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "ModifidedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Posts", "ModifidedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Contact", "ModifidedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "ModifidedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Product", "ModifidedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "ModifidedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_ProductCategory", "ModifidedDate");
            DropColumn("dbo.tb_Product", "ModifidedDate");
            DropColumn("dbo.tb_Order", "ModifidedDate");
            DropColumn("dbo.tb_Contact", "ModifidedDate");
            DropColumn("dbo.tb_Posts", "ModifidedDate");
            DropColumn("dbo.tb_News", "ModifidedDate");
            DropColumn("dbo.tb_Category", "ModifidedDate");
            DropColumn("dbo.tb_Adv", "ModifidedDate");
        }
    }
}
