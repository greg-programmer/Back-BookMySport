using System.Linq.Expressions;

namespace Back_BookMySport.Services;

public interface IRepository<TEntity>
{
    Task<int> Add(TEntity entity);
    // READ
    Task<TEntity?> GetById(int id);
    Task<TEntity?> Get(Expression<Func<TEntity, bool>> predicate);
    Task<List<TEntity>> GetAll();
    Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate);
    // UPDATE
    Task<bool> Update(TEntity entity);
    // DELETE
    Task<bool> Delete(int id);
}