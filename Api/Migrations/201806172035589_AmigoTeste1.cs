namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmigoTeste1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Amigo", "PaisId");
            DropColumn("dbo.Amigo", "EstadoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Amigo", "EstadoId", c => c.Byte(nullable: false));
            AddColumn("dbo.Amigo", "PaisId", c => c.Byte(nullable: false));
        }
    }
}
