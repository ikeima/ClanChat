using ClanChat.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace ClanChat.DAL.Repositories
{
    public class MessageRepository : BaseRepository<Message>
    {
        private readonly ApplicationDbContext _db;
        public MessageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<IEnumerable<Message>> GetAll()
        {
            return await _db.Messages
                .Include(e => e.User)
                .Include(e => e.Clan)
                .ToListAsync();
        }

        public async Task<IEnumerable<Message>> GetAllUserMessages(Guid id)
        {
            return await _db.Messages
                .Include(e => e.User)
                .Include(e => e.Clan)
                .Where(e => e.UserId == id)
                .ToListAsync();
        }

        public async Task<Message> GetLastUserMessage(Guid id)
        {
            return await _db.Messages
                .Include(e => e.User)
                .Include(e => e.Clan)
                .LastAsync(e => e.UserId == id);
        }

        public async Task<IEnumerable<Message>> GetAllClanMessages(Guid id)
        {
            return await _db.Messages
                .Include(e => e.User)
                .Include(e => e.Clan)
                .ToListAsync();
        }
    }
}
