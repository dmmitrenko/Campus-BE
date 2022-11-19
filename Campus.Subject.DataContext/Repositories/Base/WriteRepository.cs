using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Campus.Subject.DataContext.Repositories.Base;
public abstract class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : class
{
    private readonly ILogger _logger;
    private readonly CampusDbContext _context;
    protected DbSet<TEntity> _dbSet;

    protected WriteRepository(
        ILogger logger,
        CampusDbContext context)
    {
        _logger = logger;
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public void Add(TEntity entity)
    {
        _dbSet.Add(entity);
    }

    public void AddRange(IEnumerable<TEntity> entities)
    {
        _dbSet.AddRange(entities);
    }

    public void Remove(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        _dbSet.RemoveRange(entities);
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
    }

    public virtual async Task Update(TEntity entity, IEnumerable<string> fieldMasks)
    {
        var newEntry = _context.Entry(entity);
        var oldEntity = await _dbSet.FindAsync(newEntry.Property("Id").CurrentValue);
        var oldEntry = _context.Entry(oldEntity);

        var collectionFieldMasks = fieldMasks.Where(name => newEntry.Collections.Any(a => a.Metadata.Name == name));
        var propertyFieldMasks = fieldMasks.Where(name => newEntry.Properties.Any(a => a.Metadata.Name == name));

        foreach (var name in collectionFieldMasks)
        {
            var oldCollection = oldEntry.Collection(name);
            await oldCollection.LoadAsync();
            foreach (var item in oldCollection.CurrentValue!)
            {
                var oldItemEntry = _context.Entry(item);
                oldItemEntry.State = EntityState.Deleted;
            }
            var newCollection = newEntry.Collection(name);
            foreach (var item in newCollection.CurrentValue!)
            {
                var newItemEntry = _context.Entry(item);
                newItemEntry.State = EntityState.Added;
            }
        }

        foreach (var name in propertyFieldMasks)
        {
            oldEntry.Property(name).CurrentValue = newEntry.Property(name).CurrentValue;
            oldEntry.Property(name).IsModified = true;
        }
    }
}
