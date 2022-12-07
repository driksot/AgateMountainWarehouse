using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.ViewModels;

namespace AgateMountainWarehouse.Client.HttpRepository;

public interface IOrderHttpRepository
{
    Task<PagingResponse<SalesOrderViewModel>> GetOrders(PagingParameters pagingParameters);
    Task<SalesOrderViewModel> GetOrderById(string orderId);
    Task GenerateOrder(SalesOrderViewModel order);
    Task MarkFulfilled(Guid orderId);
}
