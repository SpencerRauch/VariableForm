using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VariableForm.Models;

namespace VariableForm.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Process(int PrimeId, int[] vals)
    {
        Console.WriteLine("in");
        Console.WriteLine($"PrimeId is: {PrimeId}");
        
        Console.WriteLine("Ids to associate:");
        
        foreach (int item in vals)
        {
            Console.WriteLine(item);
            
        }
        return View("Index");
        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
