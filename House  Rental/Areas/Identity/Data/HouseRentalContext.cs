using House__Rental.Areas.Identity.Data;
using House__Rental.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace House__Rental.Data;

public class HouseRentalContext : IdentityDbContext<HouseRentalUser>
{
    public HouseRentalContext(DbContextOptions<HouseRentalContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new House__RentalUserEntityConfiguration());
    }
    public DbSet<clientRecord> books { get; set; }
    public DbSet<PropertyRecord> PropertyRecords { get; set; }
}

internal class House__RentalUserEntityConfiguration : IEntityTypeConfiguration<HouseRentalUser>
{
    void IEntityTypeConfiguration<HouseRentalUser>.Configure(EntityTypeBuilder<HouseRentalUser> builder)
    {
        builder.Property(u=>u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
    }
}