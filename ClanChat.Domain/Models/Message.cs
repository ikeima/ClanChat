﻿using ClanChat.Domain.Models;

public class Message
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime Timestamp { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int ClanId { get; set; }
    public Clan Clan { get; set; }
}