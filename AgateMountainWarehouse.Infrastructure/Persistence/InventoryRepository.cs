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

    public async Task DeleteInventory(Inventory inventory)
    {
        _context.Remove(inventory);
        await _context.SaveChangesAsync();
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

    public async Task<Inventory> GetInventoryById(Guid inventoryId)
    {
        return await _context.Inventories
            .Include(i => i.Product)
            .FirstOrDefaultAsync(i => i.Id.Equals(inventoryId));
    }

    public async Task<Inventory> GetInventoryByProductId(Guid productId)
    {
        return await _context.Inventories
            .Include(i => i.Product)
            .FirstOrDefaultAsync(i => i.ProductId.Equals(productId));
    }

    public async Task UpdateQuantityOnHand(Guid inventoryId, int adjustment)
    {
        try
        {
            var inventory = await _context.Inventories
            .Include(i => i.Product)
            .FirstOrDefaultAsync(i => i.Id.Equals(inventoryId));

            inventory.QuantityOnHand = adjustment;

            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
