namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmigoEstado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Amigo", "EstadoId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Amigo", "EstadoId");
        }
    }
}
