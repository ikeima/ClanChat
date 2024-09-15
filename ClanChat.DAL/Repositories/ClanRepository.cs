using ClanChat.DAL.Data;
using ClanChat.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ClanChat.DAL.Repositories
{
    public class ClanRepository : BaseRepository<Clan>
    {
        private readonly ApplicationDbContext _db;
        public ClanRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public override async Task<IEnumerable<Clan>> GetAll()
        {
            return await _db.Clans
                .Include(e => e.Users)
                .ToListAsync();
        }

        public override async Task<Clan> GetById(Guid id)
        {
            return await _db.Clans
                .Include(e => e.Users)
                .FirstAsync(e => e.Id == id);
        }
    }
}
