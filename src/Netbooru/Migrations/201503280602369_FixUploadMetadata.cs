using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.MigrationsModel;
using System;

namespace Netbooru.Migrations
{
    public partial class FixUploadMetadata : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey("PostMetadata", "FK_PostMetadata_Upload_UploadId");
            
            migrationBuilder.DropColumn("PostMetadata", "UploadId");
            
            migrationBuilder.CreateTable("UploadMetadata",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        Value = c.String(),
                        UploadId = c.Int()
                    })
                .PrimaryKey("PK_UploadMetadata", t => t.Id);
            
            migrationBuilder.AddForeignKey(
                "UploadMetadata",
                "FK_UploadMetadata_Upload_UploadId",
                new[] { "UploadId" },
                "Upload",
                new[] { "Id" },
                cascadeDelete: false);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("UploadMetadata");
            
            migrationBuilder.AddColumn("PostMetadata", "UploadId", c => c.Int());
            
            migrationBuilder.AddForeignKey(
                "PostMetadata",
                "FK_PostMetadata_Upload_UploadId",
                new[] { "UploadId" },
                "Upload",
                new[] { "Id" },
                cascadeDelete: false);
        }
    }
}