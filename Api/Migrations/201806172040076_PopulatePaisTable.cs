namespace Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePaisTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Pais ( Name, Image) VALUES ( 'Brasil', 'ft_brazil')");
            Sql("INSERT INTO Pais ( Name, Image) VALUES ( 'Argentina', 'ft_ar')");
            Sql("INSERT INTO Pais ( Name, Image) VALUES ( 'Uruguay', 'ft_ur')");
        }
        
        public override void Down()
        {
        }
    }
}
