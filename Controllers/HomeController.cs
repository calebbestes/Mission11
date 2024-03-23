using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

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

        var bookData = new BookListViewModel
        {
            Books = _repo.Books
                .OrderBy(x => x.Title)
                . Skip((pageNum - 1) * pageSize)
                .Take(pageSize),
            PaginationInfo = new PaginationInfo
            {
                CurrentPage = pageNum,
                ItemsPerPage = pageSize,
                TotalItems = _repo.Books.Count() 
            }
        
        };
        return View(bookData);

    }
   
}