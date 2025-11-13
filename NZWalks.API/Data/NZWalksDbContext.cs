using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext: DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("45dc3547-777d-4930-a95c-fb03dad3caea"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("0bc73fd5-fa38-4ffa-8b29-2efcab5fbde6"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("80b4fc51-be6a-4483-a60d-eef1c1463803"),
                    Name = "Hard"
                }
            };
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.Parse("29d14b93-c03e-43f7-b67b-877c2d2a9247"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region()
                {
                    Id = Guid.Parse("70f95d49-c54e-4e2b-832d-d9b1a32a7ce2"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("a8d8cbb0-4a42-4828-bda7-52576aa29877"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("dd886cb3-3400-45e3-9538-d2a47d2ff0a3"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region()
                {
                    Id = Guid.Parse("7cc11c09-aee2-443b-bd91-acfed260e5a8"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region()
                {
                    Id = Guid.Parse("841ada3e-f9ea-4b44-9add-8eb07d00022d"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                }
            };
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
