using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;
using AgateMountainWarehouse.Infrastructure.RepositoryExtensions;
using Microsoft.EntityFrameworkCore;

namespace AgateMountainWarehouse.Infrastructure.Persistence;

public class InventoryRepository : IInventoryRepository
{
    private readonly WarehouseDbContext _context;

    public InventoryRepository(WarehouseDbContext context)
    {
        _context = context;
    }

    public async Task<PagedList<Inventory>> GetInventories(PagingParameters pagingParameters)
    {
        var inventories = await _context.Inventories
            .Search(pagingParameters.SearchTerm)
            .Sort(pagingParameters.OrderBy)
            .ToListAsync();

        return PagedList<Inventory>.ToPagedList(
            inventories,
            pagingParameters.PageNumber,
            pagingParameters.PageSize);
    }
}
