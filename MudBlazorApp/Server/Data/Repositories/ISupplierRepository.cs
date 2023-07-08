using MudBlazorApp.Server.Models;

namespace MudBlazorApp.Server.Data.Repositories;

public interface ISupplierRepository
{
    Task<List<Supplier>> GetSuppliers();
    Task<Supplier> GetSupplier(Guid id);
    Task AddSupplier(Supplier supplier);
    Task UpdateSupplier(Supplier supplier);
    Task DeleteSupplier(Guid id);
}
