namespace Infraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comprobanteMigr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetalleComprobante",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ComprobanteId = c.Long(nullable: false),
                        ArticuloId = c.Long(nullable: false),
                        Codigo = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articulo", t => t.ArticuloId, cascadeDelete: true)
                .ForeignKey("dbo.Comprobante", t => t.ComprobanteId, cascadeDelete: true)
                .Index(t => t.ComprobanteId)
                .Index(t => t.ArticuloId);
            
            CreateTable(
                "dbo.Comprobante",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Numero = c.Int(nullable: false),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleComprobante", "ComprobanteId", "dbo.Comprobante");
            DropForeignKey("dbo.DetalleComprobante", "ArticuloId", "dbo.Articulo");
            DropIndex("dbo.DetalleComprobante", new[] { "ArticuloId" });
            DropIndex("dbo.DetalleComprobante", new[] { "ComprobanteId" });
            DropTable("dbo.Comprobante");
            DropTable("dbo.DetalleComprobante");
        }
    }
}
