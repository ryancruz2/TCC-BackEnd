namespace Panda.SOS.Domain.Entities.Providers;
public class MobileCompanieIndex
{
    [Column("id")]
    public required string id { get; set; }
    [Column("name")]
    public required string name { get; set; }
    [Column("maker")]
    public required string maker { get; set; }
    [Column("image")]
    public required string image { get; set; }
    [Column("companies")]
    public List<string>? companies { get; set;}
}
