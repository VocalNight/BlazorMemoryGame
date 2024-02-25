using BlazorMemoryGame.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorMemoryGame.Context
{
    public class MemoryDbContext: DbContext
    {
        public MemoryDbContext(DbContextOptions<MemoryDbContext> options) : base(options) { }

        public DbSet<GameHistory> GameHistory { get; set; }
    }
}
