using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private IBookstoreRepository _repo;
    
    public HomeController(IBookstoreRepository temp)
    {
        _repo = temp;
    }

    public IActionResult Index(int pageNum)
    {
        int pageSize = 10; 
        
        var bookData = _repo.Books
            .OrderBy(x =>x.Title)
            .Skip(pageNum * pageSize)
            .Take(pageSize);
        return View(bookData);
    }
   
}