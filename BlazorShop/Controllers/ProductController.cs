using BlazorShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Title = "Super Mario Odyssey",
            Description = "Super Mario Odyssey is a 2017 platform game developed and published by Nintendo for the Nintendo Switch. An entry in the Super Mario series, it follows Mario and his new ally Cappy—a sentient hat that allows Mario to control other characters and objects—as they journey across various kingdoms to save Princess Peach from his nemesis Bowser's plans of forced marriage. In contrast to the linear gameplay of prior entries, the game returns to the primarily open-ended, 3D platform gameplay featured in Super Mario 64 and Super Mario Sunshine.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8d/Super_Mario_Odyssey.jpg/220px-Super_Mario_Odyssey.jpg",
            Price = 49.99m
        },
        new Product
        {
            Id = 2,
            Title = "Super Smash Bros. Ultimate",
            Description = "Super Smash Bros. Ultimate is a 2018 crossover fighting game developed by Bandai Namco Studios and Sora Ltd. and published by Nintendo for the Nintendo Switch. It is the fifth installment in the Super Smash Bros. series, succeeding Super Smash Bros. for Nintendo 3DS and Wii U (2014). ",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/5/50/Super_Smash_Bros._Ultimate.jpg/220px-Super_Smash_Bros._Ultimate.jpg",
            Price = 54.99m
        },
        new Product
        {
            Id = 3,
            Title = "Zelda Breath of the Wild",
            Description = "The Legend of Zelda: Breath of the Wild is a 2017 action-adventure game developed and published by Nintendo for the Nintendo Switch and Wii U. Set at the end of the Zelda timeline, the player controls an amnesiac Link as he sets out to save Princess Zelda and prevent Calamity Ganon from destroying the world.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/The_Legend_of_Zelda_Breath_of_the_Wild.jpg/220px-The_Legend_of_Zelda_Breath_of_the_Wild.jpg",
            Price = 59.99m
        },
    };

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        return Ok(Products);
    }
}