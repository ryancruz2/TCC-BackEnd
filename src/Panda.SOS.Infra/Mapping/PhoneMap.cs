﻿namespace Panda.SOS.Infra.Mapping;
public record PhoneMap : IEntityTypeConfiguration<Phones>
{
    public void Configure(EntityTypeBuilder<Phones> builder)
    {
        builder.ToTable("Phones").HasKey(p => new { p.Id, p.Name, p.Brands });
        builder.Property(x => x.Id).HasColumnType("integer");
        builder.Property(x => x.Name).HasColumnType("varchar").HasMaxLength(100);
        builder.Property(x => x.Brands).HasColumnType("varchar").HasMaxLength(100);
        builder.Property(x => x.Description).HasColumnType("text");
        builder.Property(x => x.Image).HasColumnType("varchar").HasMaxLength(50);
    }
}
