using Back_BookMySport.Models;
using Back_BookMySport.Services;
using Microsoft.AspNetCore.Mvc;

namespace Back_BookMySport.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SportCategoryController : ControllerBase
{
    private readonly IRepository<SportCategory> _sportService;

    public SportCategoryController(IRepository<SportCategory> sportService)
    {
        _sportService = sportService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        List<SportCategory> sessions = await _sportService.GetAll();
        
        return Ok(sessions);
    }
}