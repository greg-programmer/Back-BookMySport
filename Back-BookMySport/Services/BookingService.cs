using System.Linq.Expressions;
using Back_BookMySport.Data;
using Back_BookMySport.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_BookMySport.Services;

public class BookingService : IRepository<Booking>
{
    private ApplicationDbContext _dbContext;
    public BookingService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<int> Add(Booking booking)
    {
        var addedObj = await _dbContext.Bookings.AddAsync(booking);
        await _dbContext.SaveChangesAsync();
        return addedObj.Entity.Id;
    }

    public async Task<Booking?> GetById(int id)
    {
        return await _dbContext.Bookings.FindAsync(id);
    }

    public async Task<Booking?> Get(Expression<Func<Booking, bool>> predicate)
    {
        return await _dbContext.Bookings.FirstOrDefaultAsync(predicate);
    }

    public async Task<List<Booking>> GetAll()
    {
        return await _dbContext.Bookings.Include(s => s.Session.Gym).Include(s=>s.Session.SportCategory).ToListAsync();
    }

    public async Task<List<Booking>> GetAll(Expression<Func<Booking, bool>> predicate)
    {
        return await _dbContext.Bookings.Where(predicate).ToListAsync();
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
        _dbContext.Bookings.Remove(booking);
        return await _dbContext.SaveChangesAsync() > 0;
    }
}