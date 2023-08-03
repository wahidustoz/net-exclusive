using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

public class AppDbContext : DbContext
{
    private readonly ILogger<AppDbContext> logger;

    public DbSet<Student> Students { get; set; }
    public AppDbContext(
        DbContextOptions<AppDbContext> options,
        ILogger<AppDbContext> logger) 
        : base(options) 
    {
        ChangeTracker.StateChanged += OnStateChanged;
        ChangeTracker.Tracked += OnTracked;
        this.logger = logger;
    }

    private void OnTracked(object sender, EntityTrackedEventArgs e)
        => logger.LogInformation("{entity} attached to ChangeTracker.", e.Entry.Entity.GetType().Name);

    private void OnStateChanged(object sender, EntityStateChangedEventArgs e)
    {
        logger.LogInformation(
            "{entity} state changed from {from} to {to}", 
            e.Entry.Entity.GetType().Name, 
            e.OldState,
            e.NewState);

        if(e.Entry.Entity is IHasTimestamp hasTimestamp)
            if(e.NewState == EntityState.Added)
                hasTimestamp.CreatedAt = DateTime.UtcNow;
            else if(e.NewState == EntityState.Modified)
                hasTimestamp.ModifiedAt = DateTime.UtcNow;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Student>().HasKey(s => s.Id);
        builder.Entity<Student>().Property(s => s.Name).IsRequired();
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ChangeModifiedAtProperties(ChangeTracker.Entries<IHasTimestamp>().Where(e => e.State == EntityState.Modified));
        return await base.SaveChangesAsync(cancellationToken);
    }

    private void ChangeModifiedAtProperties(IEnumerable<EntityEntry<IHasTimestamp>> entries)
    {
        if(entries.Any() is false)
            return;
            
        foreach(var entry in entries)
        {
            entry.Entity.ModifiedAt = DateTime.UtcNow;
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(ChangeTracker.DebugView.LongView);
    }
}