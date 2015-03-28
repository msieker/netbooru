using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using Netbooru.Models;
using System;

namespace Netbooru.Migrations
{
    [ContextType(typeof(Netbooru.Models.NetbooruDbContext))]
    public partial class FixUploadMetadata : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201503280602369_FixUploadMetadata";
            }
        }
        
        string IMigrationMetadata.ProductVersion
        {
            get
            {
                return "7.0.0-beta3-12166";
            }
        }
        
        IModel IMigrationMetadata.TargetModel
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("Netbooru.Models.Post", b =>
                    {
                        b.Property<string>("FileName");
                        b.Property<string>("Hash");
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Key("Id");
                    });
                
                builder.Entity("Netbooru.Models.PostMetadata", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Property<string>("Key");
                        b.Property<int?>("PostId");
                        b.Property<string>("Value");
                        b.Key("Id");
                    });
                
                builder.Entity("Netbooru.Models.PostTag", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Property<int?>("PostId");
                        b.Property<int?>("TagId");
                        b.Key("Id");
                    });
                
                builder.Entity("Netbooru.Models.PostView", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Property<string>("Name");
                        b.Property<int?>("PostId");
                        b.Property<int?>("UploadId");
                        b.Key("Id");
                    });
                
                builder.Entity("Netbooru.Models.Tag", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Property<string>("Name");
                        b.Key("Id");
                    });
                
                builder.Entity("Netbooru.Models.Upload", b =>
                    {
                        b.Property<DateTimeOffset?>("Created");
                        b.Property<string>("FileName");
                        b.Property<string>("Hash");
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Property<int?>("PostId");
                        b.Property<string>("Status");
                        b.Property<string>("StorePath");
                        b.Key("Id");
                    });
                
                builder.Entity("Netbooru.Models.UploadMetadata", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Property<string>("Key");
                        b.Property<int?>("UploadId");
                        b.Property<string>("Value");
                        b.Key("Id");
                    });
                
                builder.Entity("Netbooru.Models.PostMetadata", b =>
                    {
                        b.ForeignKey("Netbooru.Models.Post", "PostId");
                    });
                
                builder.Entity("Netbooru.Models.PostTag", b =>
                    {
                        b.ForeignKey("Netbooru.Models.Tag", "TagId");
                        b.ForeignKey("Netbooru.Models.Post", "PostId");
                    });
                
                builder.Entity("Netbooru.Models.PostView", b =>
                    {
                        b.ForeignKey("Netbooru.Models.Upload", "UploadId");
                        b.ForeignKey("Netbooru.Models.Post", "PostId");
                    });
                
                builder.Entity("Netbooru.Models.Upload", b =>
                    {
                        b.ForeignKey("Netbooru.Models.Post", "PostId");
                    });
                
                builder.Entity("Netbooru.Models.UploadMetadata", b =>
                    {
                        b.ForeignKey("Netbooru.Models.Upload", "UploadId");
                    });
                
                return builder.Model;
            }
        }
    }
}