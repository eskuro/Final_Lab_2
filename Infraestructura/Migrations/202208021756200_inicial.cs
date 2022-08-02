namespace Infraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulo",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        RubroId = c.Long(nullable: false),
                        Codigo = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        Abreviatura = c.String(maxLength: 10),
                        Stock = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rubro", t => t.RubroId, cascadeDelete: true)
                .Index(t => t.RubroId);
            
            CreateTable(
                "dbo.Rubro",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articulo", "RubroId", "dbo.Rubro");
            DropIndex("dbo.Articulo", new[] { "RubroId" });
            DropTable("dbo.Rubro");
            DropTable("dbo.Articulo");
        }
    }
}
