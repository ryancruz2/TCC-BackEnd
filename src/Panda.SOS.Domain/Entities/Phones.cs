namespace Panda.SOS.Domain.Entities;
[Table("Phones")]
public class Phones
{
    [Column("id")]
    public required int Id { get; set; }
    [Column("name")]
    public required string Name { get; set; }
    [Column("maker")]
    public required string Maker { get; set; }
    [Column("image")]
    public required string Image { get; set; }
}
