namespace DevIO.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enderecos", "Bairro", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Enderecos", "Estado", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enderecos", "Estado", c => c.String(nullable: false, maxLength: 500, unicode: false));
            AlterColumn("dbo.Enderecos", "Bairro", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
    }
}
