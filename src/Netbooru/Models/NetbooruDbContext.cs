using System;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;

namespace Netbooru.Models
{
	public class NetbooruDbContext : DbContext
	{
		public DbSet<Post> Posts { get; set; }
		public DbSet<Upload> Uploads { get; set; }
		public DbSet<Tag> Tags { get; set; }		

		protected override void OnModelCreating(Microsoft.Data.Entity.Metadata.ModelBuilder builder)
		{
			//builder.Entity<Post>(b =>
			//{
			//	b.
			//});
		}

		protected override void OnConfiguring(DbContextOptions options)
		{
			options.UseSqlServer();
		}
	}
}