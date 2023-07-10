using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorApp.Models;

namespace RazorApp.Pages.Categories;

public class CreateModel : PageModel
{
    public Category Category { get; set; }

    public void OnGet()
    {

    }
}