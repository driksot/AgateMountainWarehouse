using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.ViewModels;

namespace AgateMountainWarehouse.Client.HttpRepository;

public interface IInventoryHttpRepository
{
    Task<PagingResponse<InventoryViewModel>> GetInventories(PagingParameters pagingParameters);
    Task<InventoryViewModel> GetInventoryByProductId(string productId);
    Task UpdateQuantityOnHand(InventoryAdjustmentViewModel inventoryAdjustment);
    Task DeleteInventory(Guid inventoryId);
}
