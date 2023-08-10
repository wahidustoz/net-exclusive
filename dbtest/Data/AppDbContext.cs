using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Student>()
            .HasKey(x => x.Id);

        builder.Entity<Student>()
            .Property(s => s.EnrolledDate)
            .HasDefaultValueSql("CURRENT_DATE");

        builder.Entity<Student>()
            .Property(s => s.Phone)
            .IsRequired()
            .HasMaxLength(15);

        base.OnModelCreating(builder);
    }
}