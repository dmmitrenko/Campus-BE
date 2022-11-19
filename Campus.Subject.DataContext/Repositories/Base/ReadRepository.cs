using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Campus.Subject.DataContext.Repositories.Base;
public class ReadRepository<TEntity> : IReadRepository<TEntity> where TEntity : class
{
    private readonly CampusDbContext _context;
    protected DbSet<TEntity> _dbSet;

    public ReadRepository(CampusDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public virtual async Task<TEntity?> FindByCondition(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.FirstOrDefaultAsync(predicate);
    }

    public virtual async Task<TEntity?> FindByIdAsync(params object[] keys)
    {
        return await _dbSet.FindAsync(keys);
    }

    public virtual IQueryable<TEntity> GetAll()
    {
        return _dbSet.AsQueryable();
    }
}
