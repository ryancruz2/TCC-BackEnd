namespace Panda.SOS.Infra.Context;

public class EFContext : DbContext
{
    public EFContext()
    {

    }

    public EFContext(DbContextOptions<EFContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFContext).Assembly);
    }

    public DbSet<Companies> Companies { get; set; }
    public DbSet<Phones> Phones { get; set; }
    public DbSet<PhoneCompany> PhoneCompany { get; set; }
}
