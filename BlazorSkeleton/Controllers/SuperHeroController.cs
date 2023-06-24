using BlazorSkeleton.Data;
using BlazorSkeleton.Services.SuperHeroService;

using Microsoft.AspNetCore.Mvc;

namespace BlazorSkeleton.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuperHeroController : ControllerBase
{
    private readonly ISuperHeroService _superHeroService;

    public SuperHeroController(ISuperHeroService superHeroService)
    {
        _superHeroService = superHeroService;
    }

    [HttpGet]
    public async Task<ActionResult<List<SuperHero>>> GetAll()
    {
        return Ok(await _superHeroService.GetAll());
    }
}