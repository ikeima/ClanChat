using ClanChat.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace ClanChat.DAL.Repositories
{
    public class UsersRepository : BaseRepository<User>
    {
        private readonly ApplicationDbContext _db;
        public UsersRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<IEnumerable<User>> GetAll()
        {
            return await _db.Users
                .Include(e => e.Clan)
                .ToListAsync();
        }

        public override async Task<User> GetById(Guid id)
        {
            return await _db.Users
                .Include(e => e.Clan)
                .FirstAsync(e => e.Id == id);
        }
    }
}
