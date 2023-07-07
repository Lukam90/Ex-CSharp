using Microsoft.AspNetCore.Mvc;
using MudBlazorApp.Data.Repositories;
using MudBlazorApp.Models;
using MudBlazorApp.Models.Dto;

namespace MudBlazorApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SupplierController : ControllerBase
{
    private readonly ISupplierRepository _supplierRepository;

    public SupplierController(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }

    // GET: api/<SupplierController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Supplier>>> Get()
    {
        var suppliers = await _supplierRepository.GetSuppliers();

        return Ok(suppliers);
    }

    // GET: api/<SupplierController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<Supplier>>> Get(Guid id)
    {
        var supplier = await _supplierRepository.GetSupplier(id);

        if (supplier != null)
        {
            return Ok(supplier);
        }

        return BadRequest();
    }

    // POST api/
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreateSupplierDto createSupplierDto) 
    {
        var supplierToCreate = new Supplier()
        {
            Name = createSupplierDto.Name,
            Company = createSupplierDto.Company,
            Email = createSupplierDto.Email
        };

        await _supplierRepository.AddSupplier(supplierToCreate);

        return Ok("Supplier created");
    }

    // PUT api/<SupplierController>/5
    [HttpPut]
    public async Task<ActionResult> Put(Supplier supplier)
    {
        await _supplierRepository.UpdateSupplier(supplier);

        return Ok("Supplier updated");
    }

    // DELETE api/<SupplierController>/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(Guid id)
    {
        await _supplierRepository.DeleteSupplier(id);

        return Ok("Supplier deleted");
    }
}