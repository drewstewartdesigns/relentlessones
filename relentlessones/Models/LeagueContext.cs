using System;
using Microsoft.EntityFrameworkCore;
namespace relentlessones.Models
{
	public class LeagueContext : DbContext
	{
		public LeagueContext(DbContextOptions<LeagueContext> options) : base(options)
		{

		}

        public DbSet<relentlessones.Models.League> League { get; set; }
	}
}
