namespace Panda.SOS.Domain.Entities;
[Table("PhoneCompany")]
public class PhoneCompany
{
    [Column("cnpj")]
    public required string Cnpj { get; set; }
    [Column("id")]
    public required int Id { get; set; }
    [Column("parts")]
    public required JsonArray Parts { get; set; }
    public required virtual Phones Phones { get; set; }
    public required virtual Companies Companies { get; set; }
}
