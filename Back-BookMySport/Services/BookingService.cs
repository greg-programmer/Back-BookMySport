using System.Linq.Expressions;
using Back_BookMySport.Data;
using Back_BookMySport.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_BookMySport.Services;

public class BookingService : IRepository<Booking>
{
    private ApplicationDbContext _dbContext;
    public BookingService()
    {
        
    }
    public async Task<int> Add(Booking booking)
    {
        var addedObj = await _dbContext.BookingsDBList.AddAsync(booking);
        await _dbContext.SaveChangesAsync();
        return addedObj.Entity.Id;
    }

    public async Task<Booking?> GetById(int id)
    {
        return await _dbContext.BookingsDBList.FindAsync(id);
    }

    public async Task<Booking?> Get(Expression<Func<Booking, bool>> predicate)
    {
        return await _dbContext.BookingsDBList.FirstOrDefaultAsync(predicate);
    }

    public async Task<List<Booking>> GetAll()
    {
        return await _dbContext.BookingsDBList.ToListAsync();
    }

    public async Task<List<Booking>> GetAll(Expression<Func<Booking, bool>> predicate)
    {
        return await _dbContext.BookingsDBList.Where(predicate).ToListAsync();
    }

    public Task<bool> Update(Booking entity)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Delete(int id)
    {
        var booking = await GetById(id);
        if (booking == null)
            return false;
        _dbContext.BookingsDBList.Remove(booking);
        return await _dbContext.SaveChangesAsync() > 0;
    }
}