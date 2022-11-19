namespace Campus.Subject.DataContext.Repositories.Base;
public interface IWriteRepository<TEntity>
{
    /// <summary>
    /// Adds entity into DBContext
    /// </summary>
    /// <param name="entity">entity framework's entity</param>
    void Add(TEntity entity);

    /// <summary>
    /// Adds multiple entities into DBContext
    /// </summary>
    /// <param name="entities">entity framework's entity</param>
    void AddRange(IEnumerable<TEntity> entities);

    /// <summary>
    /// Removes entities from DBContext
    /// </summary>
    /// <param name="entities">entity framework's entity</param>
    void Remove(TEntity entities);

    /// <summary>
    /// Removes multiple entities from DBContext
    /// </summary>
    /// <param name="entity">entity framework's entity</param>
    void RemoveRange(IEnumerable<TEntity> entity);

    /// <summary>
    /// Updates existing entity or creates a new one
    /// </summary>
    /// <param name="entity">entity framework's entity</param>
    void Update(TEntity entity);

    /// <summary>
    /// Updates existing entity using field masks
    /// </summary>
    /// <param name="entity">entity framework's entity</param>
    /// <param name="fieldMasks">field masks, which indicate properties for update</param>
    Task Update(TEntity entity, IEnumerable<string> fieldMasks);
}
