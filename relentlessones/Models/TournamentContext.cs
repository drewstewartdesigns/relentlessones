using System;
using Microsoft.EntityFrameworkCore;
namespace relentlessones.Models
{
	public class TournamentContext : DbContext
	{
		public TournamentContext(DbContextOptions<TournamentContext> options) : base(options)
		{

		}

		public DbSet<relentlessones.Models.Tournament> Tournament { get; set; }
	}
}
