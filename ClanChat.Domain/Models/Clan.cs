using ClanChat.DAL.Repositories;

namespace ClanChat.Domain.Models
{
    public class Clan : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
