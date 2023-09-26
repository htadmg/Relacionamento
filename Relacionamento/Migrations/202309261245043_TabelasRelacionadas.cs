﻿namespace Relacionamento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasRelacionadas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModeloId = c.Int(nullable: false),
                        Nome = c.String(),
                        Ano = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modeloes", t => t.ModeloId, cascadeDelete: true)
                .Index(t => t.ModeloId);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carroes", "ModeloId", "dbo.Modeloes");
            DropIndex("dbo.Carroes", new[] { "ModeloId" });
            DropTable("dbo.Modeloes");
            DropTable("dbo.Carroes");
        }
    }
}
