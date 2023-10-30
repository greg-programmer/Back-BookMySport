using System.Linq.Expressions;
using Back_BookMySport.Data;
using Back_BookMySport.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_BookMySport.Services;

public class SportService : IRepository<SportCategory>
{
    private ApplicationDbContext _dbContext;

    public SportService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public Task<int> Add(SportCategory entity)
    {
        throw new NotImplementedException();
    }

    public Task<SportCategory?> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SportCategory?> Get(Expression<Func<SportCategory, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task<List<SportCategory>> GetAll()
    {
        return await _dbContext.SportCategories.ToListAsync();
    }

    public Task<List<SportCategory>> GetAll(Expression<Func<SportCategory, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Update(SportCategory entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }
}