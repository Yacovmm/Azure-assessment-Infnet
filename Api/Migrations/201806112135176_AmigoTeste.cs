namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmigoTeste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Amigo", "PaisId", c => c.Byte(nullable: false));
            AddColumn("dbo.Amigo", "EstadoId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Amigo", "EstadoId");
            DropColumn("dbo.Amigo", "PaisId");
        }
    }
}
