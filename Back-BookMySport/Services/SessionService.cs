using System.Linq.Expressions;
using Back_BookMySport.Data;
using Back_BookMySport.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_BookMySport.Services;

public class SessionService : IRepository<Session>
{
    private ApplicationDbContext _dbContext;

    public SessionService(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<int> Add(Session session)
    {
        var addedObj = await _dbContext.Sessions.AddAsync(session);
        await _dbContext.SaveChangesAsync();
        return addedObj.Entity.Id;
    }

    public async Task<Session?> GetById(int id)
    {
        return await _dbContext.Sessions.Include(s=>s.Bookings).Include(s => s.SportCategory).Include(s => s.Gym).FirstOrDefaultAsync(s=>s.Id == id);
    }

    public async Task<Session?> Get(Expression<Func<Session, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Session>> GetAll()
    {
        return await _dbContext.Sessions.ToListAsync();
    }

    public async Task<List<Session>> GetAll(Expression<Func<Session, bool>> predicate)
    {
        return await _dbContext.Sessions.Where(predicate).ToListAsync();
    }

    public async Task<bool> Update(Session session)
    {
        var sessionFromDb = await GetById(session.Id);

        if (sessionFromDb == null)
            return false;

        if (sessionFromDb.Name != session.Name)
            sessionFromDb.Name = session.Name;
        if (sessionFromDb.Description != session.Description)
            sessionFromDb.Description = session.Description;
        if (sessionFromDb.MaxBooking != session.MaxBooking)
            sessionFromDb.MaxBooking = session.MaxBooking;
        if (sessionFromDb.ImagePath != session.ImagePath)
            sessionFromDb.ImagePath = session.ImagePath;


        return await _dbContext.SaveChangesAsync() > 0;
    }
    

    public async Task<bool> Delete(int id)
    {
        var session = await GetById(id);
        if (session == null)
            return false;
        _dbContext.Sessions.Remove(session);
        return await _dbContext.SaveChangesAsync() > 0;
    }
}