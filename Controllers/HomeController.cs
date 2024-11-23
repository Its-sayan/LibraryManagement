using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers;

public class HomeController : Controller
{
    // private readonly ILogger<HomeController> _logger;
    private readonly DbLibrarymangementContext context;

    // public HomeController(ILogger<HomeController> logger, DbLibrarymangementContext context)
    // {
    //     _logger = logger;
    //     _context = context;
    // }
    public HomeController(DbLibrarymangementContext context){
        this.context = context;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
