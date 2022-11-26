using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;

namespace AgateMountainWarehouse.Application.Interfaces;

public interface IInventoryRepository
{
    Task<PagedList<Inventory>> GetInventories(PagingParameters pagingParameters);
}
