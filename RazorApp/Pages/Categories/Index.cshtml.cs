using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorApp.Data;
using RazorApp.Models;

namespace RazorApp.Pages.Categories;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _db;

    public IEnumerable<Category> Categories { get; set; }

    public IndexModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet()
    {
        Categories = _db.Categories;
    }
}