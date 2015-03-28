using System;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;

namespace Netbooru.Models
{
	public class NetbooruDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Post> Posts { get; set; }

		private static bool _created = false;

		public NetbooruDbContext()
		{

		}

		protected override void OnConfiguring(DbContextOptions options)
		{
			options.UseSqlServer();
		}
	}
}