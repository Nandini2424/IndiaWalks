using IndiaWalks.Models;
using IndiaWalks.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace IndiaWalks.Data
{
    public class IndiaWalksDbContext:DbContext
    {
        //Contructor 
        public IndiaWalksDbContext(DbContextOptions<IndiaWalksDbContext> option) :base(option){ }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> walks { get; set; }
        public DbSet<WalkDifficulty> walkDifficulty { get; set; }

    }
}
