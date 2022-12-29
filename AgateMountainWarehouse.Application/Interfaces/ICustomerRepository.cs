using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;

namespace AgateMountainWarehouse.Application.Interfaces;

public interface ICustomerRepository
{
    Task<PagedList<Customer>> GetCustomers(PagingParameters pagingParameters);
    Task<Customer> GetCustomerById(Guid customerId);
    Task CreateCustomer(Customer customer);
    Task UpdateCustomer(Customer customer, Customer dbCustomer);
    Task ArchiveCustomer(Guid customerId);
}
