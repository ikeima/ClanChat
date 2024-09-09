using ClanChat.DAL.Data;
using ClanChat.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClanChat.DAL.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T>
        where T : BaseEntity
    {
        private readonly ApplicationDbContext _db;

        protected BaseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public virtual async Task<T> Create(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> Delete(Guid id)
        {
            T entity = await _db.Set<T>().FirstAsync(x => x.Id == id);
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await _db.Set<T>().FirstAsync(x => x.Id == id);
        }

        public virtual async Task<T> Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
                if (disposing)
                    _db.Dispose();
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
