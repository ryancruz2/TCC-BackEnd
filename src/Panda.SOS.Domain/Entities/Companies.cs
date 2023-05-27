namespace Panda.SOS.Domain.Entities;
[Table("Companies")]
public class Companies
{
    [Column("cnpj")]
    public required string Cnpj { get; set; }
    [Column("name")]
    public required string Name { get; set; }
    [Column("description")]
    public required string Description { get; set; }
}
