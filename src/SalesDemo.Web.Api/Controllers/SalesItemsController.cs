using Microsoft.AspNetCore.Mvc;

namespace SalesDemo.Web.Api.Controllers;

public class SalesItemsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    
}