using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.ViewModels;

namespace AgateMountainWarehouse.Client.HttpRepository;

public interface ICustomerHttpRepository
{
    Task<PagingResponse<CustomerViewModel>> GetCustomers(PagingParameters pagingParameters);
    Task<CustomerViewModel> GetCustomerById(string customerId);
    Task CreateCustomer(CustomerViewModel customer);
    Task UpdateCustomer(CustomerViewModel customer);
    Task ArchiveCustomer(Guid id);
}
