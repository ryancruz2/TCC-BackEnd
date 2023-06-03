namespace Panda.SOS.Infra.Mapping;
public record PhoneMap : IEntityTypeConfiguration<Phones>
{
    public void Configure(EntityTypeBuilder<Phones> builder)
    {
        builder.ToTable("Phones").HasKey(p => new { p.Id });
        builder.Property(x => x.Id).HasColumnType("integer");
        builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(100);
        builder.Property(x => x.Maker).HasColumnType("varchar").HasMaxLength(100);
        builder.Property(x => x.Image).HasColumnType("varchar").HasMaxLength(50);
    }
}
