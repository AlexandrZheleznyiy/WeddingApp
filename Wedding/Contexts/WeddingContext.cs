using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wedding.Models;
using Wedding.Models.Enums;

namespace Wedding.Contexts
{
    public class WeddingContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; } = null!;
        public DbSet<ClothesColour> ClothesColours { get; set; } = null!;
        public DbSet<DatingHistory> DatingHistories { get; set; } = null!;
        public DbSet<GuestProfile> GuestProfiles { get; set; } = null!;
        public DbSet<TimeTable> TimeTables { get; set; } = null!;
        public DbSet<WeddingDay> WeddingDays { get; set; } = null!;

        public WeddingContext(DbContextOptions<WeddingContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ClothesColour = new EnumToStringConverter<ClothesColourEnum>();
            modelBuilder.Entity<ClothesColour>().Property(e => e.ClothesEnum).HasConversion(ClothesColour);

            var GuestAction = new EnumToStringConverter<GuestActionEnum>();
            modelBuilder.Entity<GuestProfile>().Property(e => e.GuestActionEnum).HasConversion(GuestAction);

            var GuestDrink = new EnumToStringConverter<GuestDrinkEnum>();
            modelBuilder.Entity<GuestProfile>().Property(e => e.GuestDrinkEnum).HasConversion(GuestDrink);
        }
    }
}
