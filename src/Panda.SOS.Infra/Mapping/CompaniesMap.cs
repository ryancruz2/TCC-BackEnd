namespace Panda.SOS.Infra.Mapping;
public record CompaniesMap : IEntityTypeConfiguration<Companies>
{
    public void Configure(EntityTypeBuilder<Companies> builder)
    {
        builder.ToTable("Companies").HasKey(x => x.Cnpj);
    }
}
