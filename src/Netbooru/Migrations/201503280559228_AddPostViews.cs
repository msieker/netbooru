using Microsoft.Data.Entity.Relational.Migrations;
using Microsoft.Data.Entity.Relational.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Migrations.MigrationsModel;
using System;

namespace Netbooru.Migrations
{
    public partial class AddPostViews : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("Post",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        Hash = c.String()
                    })
                .PrimaryKey("PK_Post", t => t.Id);
            
            migrationBuilder.CreateTable("PostMetadata",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        Value = c.String(),
                        UploadId = c.Int(),
                        PostId = c.Int()
                    })
                .PrimaryKey("PK_PostMetadata", t => t.Id);
            
            migrationBuilder.CreateTable("PostTag",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TagId = c.Int(),
                        PostId = c.Int()
                    })
                .PrimaryKey("PK_PostTag", t => t.Id);
            
            migrationBuilder.CreateTable("PostView",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UploadId = c.Int(),
                        PostId = c.Int()
                    })
                .PrimaryKey("PK_PostView", t => t.Id);
            
            migrationBuilder.CreateTable("Tag",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String()
                    })
                .PrimaryKey("PK_Tag", t => t.Id);
            
            migrationBuilder.CreateTable("Upload",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTimeOffset(),
                        FileName = c.String(),
                        Hash = c.String(),
                        Status = c.String(),
                        StorePath = c.String(),
                        PostId = c.Int()
                    })
                .PrimaryKey("PK_Upload", t => t.Id);
            
            migrationBuilder.AddForeignKey(
                "PostMetadata",
                "FK_PostMetadata_Upload_UploadId",
                new[] { "UploadId" },
                "Upload",
                new[] { "Id" },
                cascadeDelete: false);
            
            migrationBuilder.AddForeignKey(
                "PostMetadata",
                "FK_PostMetadata_Post_PostId",
                new[] { "PostId" },
                "Post",
                new[] { "Id" },
                cascadeDelete: false);
            
            migrationBuilder.AddForeignKey(
                "PostTag",
                "FK_PostTag_Tag_TagId",
                new[] { "TagId" },
                "Tag",
                new[] { "Id" },
                cascadeDelete: false);
            
            migrationBuilder.AddForeignKey(
                "PostTag",
                "FK_PostTag_Post_PostId",
                new[] { "PostId" },
                "Post",
                new[] { "Id" },
                cascadeDelete: false);
            
            migrationBuilder.AddForeignKey(
                "PostView",
                "FK_PostView_Upload_UploadId",
                new[] { "UploadId" },
                "Upload",
                new[] { "Id" },
                cascadeDelete: false);
            
            migrationBuilder.AddForeignKey(
                "PostView",
                "FK_PostView_Post_PostId",
                new[] { "PostId" },
                "Post",
                new[] { "Id" },
                cascadeDelete: false);
            
            migrationBuilder.AddForeignKey(
                "Upload",
                "FK_Upload_Post_PostId",
                new[] { "PostId" },
                "Post",
                new[] { "Id" },
                cascadeDelete: false);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey("PostMetadata", "FK_PostMetadata_Post_PostId");
            
            migrationBuilder.DropForeignKey("PostTag", "FK_PostTag_Post_PostId");
            
            migrationBuilder.DropForeignKey("PostView", "FK_PostView_Post_PostId");
            
            migrationBuilder.DropForeignKey("Upload", "FK_Upload_Post_PostId");
            
            migrationBuilder.DropForeignKey("PostTag", "FK_PostTag_Tag_TagId");
            
            migrationBuilder.DropForeignKey("PostMetadata", "FK_PostMetadata_Upload_UploadId");
            
            migrationBuilder.DropForeignKey("PostView", "FK_PostView_Upload_UploadId");
            
            migrationBuilder.DropTable("Post");
            
            migrationBuilder.DropTable("PostMetadata");
            
            migrationBuilder.DropTable("PostTag");
            
            migrationBuilder.DropTable("PostView");
            
            migrationBuilder.DropTable("Tag");
            
            migrationBuilder.DropTable("Upload");
        }
    }
}