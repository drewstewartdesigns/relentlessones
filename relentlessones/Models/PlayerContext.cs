using System;
using Microsoft.EntityFrameworkCore;
namespace relentlessones.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext (DbContextOptions<PlayerContext> options) : base(options) {
            
        }

        public DbSet<relentlessones.Models.Player> Player { get; set; }
    }
}
