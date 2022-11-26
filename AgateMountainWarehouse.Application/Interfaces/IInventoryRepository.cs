using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;

namespace AgateMountainWarehouse.Application.Interfaces;

public interface IInventoryRepository
{
    Task<PagedList<Inventory>> GetInventories(PagingParameters pagingParameters);
    Task<Inventory> GetInventoryById(Guid inventoryId);
    Task<Inventory> GetInventoryByProductId(Guid productId);
    Task UpdateQuantityOnHand(Guid inventoryId, int adjustment);
    Task DeleteInventory(Inventory inventory);
}
