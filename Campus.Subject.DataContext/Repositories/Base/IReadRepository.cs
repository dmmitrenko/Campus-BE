using System.Linq.Expressions;

namespace Campus.Subject.DataContext.Repositories.Base;
public interface IReadRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// Enables further filtering by returning IQueryable
    /// </summary>
    /// <returns>entity framework's entity</returns>
    IQueryable<TEntity> GetAll();

    /// <summary>
    /// Finds and returns TEntity based on Primary Key
    /// </summary>
    /// <param name="keys">Primary Keys</param>
    /// <returns>entity framework's entity</returns>
    Task<TEntity?> FindByIdAsync(params object[] keys);

    /// <summary>
    /// Finds and returns TEntity based on the predicate
    /// </summary>
    /// <param name="predicate">customized condition</param>
    /// <returns>entity framework's entity</returns>
    Task<TEntity?> FindByCondition(Expression<Func<TEntity, bool>> predicate);
}
