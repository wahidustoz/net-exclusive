using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; } 
    public DbSet<DriverLicense> DriverLicenses { get; set; } 
    public DbSet<Car> Cars { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasKey(e => e.Id);
        
        modelBuilder.Entity<User>()
            .Property(e => e.Username)
            .HasMaxLength(20)
            .IsRequired();
        
        modelBuilder.Entity<User>()
            .HasIndex(e => e.Email)
            .IsUnique();

        modelBuilder.Entity<User>()
            .HasIndex(e => e.Username)
            .IsUnique();
        
        modelBuilder.Entity<User>()
            .Property(e => e.Email)
            .IsRequired();

        modelBuilder.Entity<User>()
            .HasOne(d => d.DriverLicense)
            .WithOne(u => u.Holder)
            .HasForeignKey<DriverLicense>(u => u.Id)
            .HasPrincipalKey<User>(u => u.Id);
        
        modelBuilder.Entity<User>()
            .HasMany(u => u.Cars)
            .WithOne(c => c.Owner)
            .HasPrincipalKey(c => c.Id)
            .IsRequired();

        modelBuilder.Entity<Car>()
            .HasKey(e => e.Id);
        modelBuilder.Entity<Car>()
            .Property(e => e.Color)
            .HasMaxLength(20);
        modelBuilder.Entity<Car>()
            .Property(e => e.Brand)
            .HasMaxLength(20)
            .IsRequired();
        modelBuilder.Entity<Car>()
            .Property(e => e.Model)
            .HasMaxLength(20)
            .IsRequired();
    }
}