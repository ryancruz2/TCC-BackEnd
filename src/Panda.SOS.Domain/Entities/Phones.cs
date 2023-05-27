namespace Panda.SOS.Domain.Entities;
[Table("Phones")]
public class Phones
{
    [Column("id")]
    public required int Id { get; set; }
    [Column("name")]
    public required string Name { get; set; }
    [Column("brands")]
    public required string Brands { get; set; }
    [Column("description")]
    public required string Description { get; set; }
    [Column("image")]
    public required string Image { get; set; }
}
