using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;
using AgateMountainWarehouse.Infrastructure.RepositoryExtensions;
using Microsoft.EntityFrameworkCore;

namespace AgateMountainWarehouse.Infrastructure.Persistence;

public class CustomerRepository : ICustomerRepository
{
    private readonly WarehouseDbContext _context;

    public CustomerRepository(WarehouseDbContext context)
    {
        _context = context;
    }

    public async Task CreateCustomer(Customer customer)
    {
        _context.Add(customer);

        await _context.SaveChangesAsync();
    }

    public async Task DeleteCustomer(Customer customer)
    {
        _context.Remove(customer);
        await _context.SaveChangesAsync();

    }

    public async Task<Customer> GetCustomerById(Guid customerId)
    {
        var customer = await _context.Customers
            .Include(c => c.Address)
            .FirstOrDefaultAsync(c => c.Id.Equals(customerId));

        return customer;
    }

    public async Task<PagedList<Customer>> GetCustomers(PagingParameters pagingParameters)
    {
        var customers = await _context.Customers
            .Include(c => c.Address)
            .Search(pagingParameters.SearchTerm)
            .Sort(pagingParameters.OrderBy)
            .ToListAsync();

        return PagedList<Customer>.ToPagedList(
            customers,
            pagingParameters.PageNumber,
            pagingParameters.PageSize);
    }

    public async Task UpdateCustomer(Customer customer, Customer dbCustomer)
    {
        dbCustomer.FirstName= customer.FirstName;
        dbCustomer.LastName= customer.LastName;
        dbCustomer.Address= customer.Address;

        await _context.SaveChangesAsync();
    }
}
