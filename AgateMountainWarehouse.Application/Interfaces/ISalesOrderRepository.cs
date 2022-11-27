using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;

namespace AgateMountainWarehouse.Application.Interfaces;

public interface ISalesOrderRepository
{
    Task<PagedList<SalesOrder>> GetOrders(PagingParameters pagingParameters);
    Task<SalesOrder> GetOrderById(Guid orderId);
    Task GenerateOrder(SalesOrder order);
    Task MarkFulfilled(Guid orderId);
}
