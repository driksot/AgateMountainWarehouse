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
        var inventory = await _context.Inventories
            .Include(i => i.Product)
            .FirstOrDefaultAsync(i => i.ProductId.Equals(productId));

        return inventory ?? new Inventory();
    }

    public async Task UpdateQuantityOnHand(Guid inventoryId, int adjustment)
    {
        try
        {
            var inventory = await _context.Inventories
            .Include(i => i.Product)
            .FirstOrDefaultAsync(i => i.Id.Equals(inventoryId));

            if (inventory is not null)
                inventory.QuantityOnHand = adjustment;

            try
            {
                await CreateSnapshot();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private async Task CreateSnapshot()
    {
        var inventories = await _context.Inventories.Include(i => i.Product).ToListAsync();

        foreach (var inv in inventories)
        {
            var snapshot = new InventorySnapshot
            {
                InventoryId = inv.Id,
                Inventory = inv,
                SnapshotQuantity = inv.QuantityOnHand,
                SnapshotTime = DateTime.Now
            };

            await _context.AddAsync(snapshot);
        }
    }
}
