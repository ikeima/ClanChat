using ClanChat.DAL.Repositories;
using ClanChat.Domain.Models;

public class User : BaseEntity
{
    public string Name { get; set; }
    public int ClanId { get; set; }
    public Clan Clan { get; set; }
}