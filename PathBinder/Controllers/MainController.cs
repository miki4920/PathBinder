using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize]                     
[Route("")]                      
public class MainController : Controller
{
    private readonly ApplicationDbContext _db;
    private readonly UserManager<ApplicationUser> _userMgr;

    public MainController(ApplicationDbContext db, UserManager<ApplicationUser> userMgr)
    {
        _db = db;
        _userMgr = userMgr;
    }

    [HttpGet("")]          
    [HttpGet("library")]
    public async Task<IActionResult> Library()
    {
        var uid = _userMgr.GetUserId(User)!;

        var docs = await _db.Files
            .Where(f => f.UserId == uid)
            .OrderByDescending(f => f.LastModified)
            .ToListAsync();

        return View(docs);               
    }

    [HttpGet("write/{id}")]
    public async Task<IActionResult> Write(string id)
    {
        var uid = _userMgr.GetUserId(User)!;

        var doc = await _db.Files
            .FirstOrDefaultAsync(f => f.Id == id && f.UserId == uid);

        if (doc == null) return NotFound();

        return View(doc);                
    }
}
