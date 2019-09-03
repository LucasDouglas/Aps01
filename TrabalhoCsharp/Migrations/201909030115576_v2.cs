namespace TrabalhoCsharp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Compromissos", "Local", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Compromissos", "Local");
        }
    }
}
