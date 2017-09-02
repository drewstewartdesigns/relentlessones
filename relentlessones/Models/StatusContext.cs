using System;
using Microsoft.EntityFrameworkCore;
namespace relentlessones.Models
{
	public class StatusContext : DbContext
	{
		public StatusContext(DbContextOptions<StatusContext> options) : base(options)
		{

		}

		public DbSet<relentlessones.Models.Status> Status { get; set; }
	}
}
