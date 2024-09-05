using ClanChat.Domain.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ClanId { get; set; }
    public Clan Clan { get; set; }
}