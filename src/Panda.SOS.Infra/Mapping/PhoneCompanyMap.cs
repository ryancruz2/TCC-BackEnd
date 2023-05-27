namespace Panda.SOS.Infra.Mapping;
public record PhoneCompanyMap : IEntityTypeConfiguration<PhoneCompany>
{
    public void Configure(EntityTypeBuilder<PhoneCompany> builder)
    {
        builder.ToTable("PhoneCompany").HasKey(e => new { e.Id, e.Cnpj });
        builder.HasOne(x => x.Phones).WithMany().HasForeignKey(x => x.Id);
        builder.HasOne(x => x.Companies).WithMany().HasForeignKey(x => x.Cnpj);
        builder.Property(x => x.Parts).HasColumnType("jsonb");
    }
}
