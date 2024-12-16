using ClanChat.Domain.Models;

public class Message
{
    public Guid Id { get; set; }
    public string Text { get; set; }
    public DateTime Timestamp { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid ClanId { get; set; }
    public Clan Clan { get; set; }
}