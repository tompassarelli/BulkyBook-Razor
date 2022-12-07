using System.Reflection;
using AbbyWeb.Data;
using AbbyWeb.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories;

public class IndexModel : PageModel
{
    public readonly ApplicationDbContext _db;
    public IEnumerable<Category> Categories { get; set; }
    
    public IndexModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet()
    {
        Categories = _db.Category;
    }
}