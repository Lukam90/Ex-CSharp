using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorApp.Data;
using RazorApp.Models;

namespace RazorApp.Pages.Categories;

[BindProperties]
public class EditModel : PageModel
{
    private readonly ApplicationDbContext _db;
    
    public Category Category { get; set; }

    public EditModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet(int id)
    {
        Category = _db.Categories.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
        if (Category.Name == Category.DisplayOrder.ToString())
        {
            ModelState.AddModelError("Category.Name", "The DisplayOrder cannot exactly match the Name.");
        }

        if (ModelState.IsValid)
        {
            _db.Categories.Update(Category);

            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        return Page();
    }
}