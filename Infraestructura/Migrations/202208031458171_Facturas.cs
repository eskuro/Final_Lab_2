namespace Infraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Facturas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comprobante_Factura",
                c => new
                    {
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comprobante", t => t.Id)
                .Index(t => t.Id);
            
            DropColumn("dbo.Comprobante", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comprobante", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Comprobante_Factura", "Id", "dbo.Comprobante");
            DropIndex("dbo.Comprobante_Factura", new[] { "Id" });
            DropTable("dbo.Comprobante_Factura");
        }
    }
}
