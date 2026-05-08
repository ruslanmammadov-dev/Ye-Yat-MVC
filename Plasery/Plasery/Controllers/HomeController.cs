using Microsoft.AspNetCore.Mvc;
using Plasery.AppDb; // AppDbContext-in olduğu qovluq
using Plasery.Models;
using Microsoft.EntityFrameworkCore;
using Plasery.AppDb;

namespace Plasery.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
