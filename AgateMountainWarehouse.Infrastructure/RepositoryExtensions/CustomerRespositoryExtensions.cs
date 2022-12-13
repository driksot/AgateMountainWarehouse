using AgateMountainWarehouse.Domain.Entities;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace AgateMountainWarehouse.Infrastructure.RepositoryExtensions;

public static class CustomerRespositoryExtensions
{
    public static IQueryable<Customer> Search(this IQueryable<Customer> customer, string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return customer;
        var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
        return customer.Where(p => p.FirstName.ToLower().Contains(lowerCaseSearchTerm) | 
            p.LastName.ToLower().Contains(lowerCaseSearchTerm));
    }

    public static IQueryable<Customer> Sort(this IQueryable<Customer> customer, string orderByQueryString)
    {
        if (string.IsNullOrWhiteSpace(orderByQueryString))
            return customer.OrderBy(c => c.LastName);

        var orderParams = orderByQueryString.Trim().Split(',');
        var propertyInfos = typeof(Customer).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var orderQueryBuilder = new StringBuilder();

        foreach (var param in orderParams)
        {
            if (string.IsNullOrWhiteSpace(param))
                continue;

            var propertyFromQueryName = param.Split(" ")[0];
            var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

            if (objectProperty == null)
                continue;

            var direction = param.EndsWith(" desc") ? "descending" : "ascending";
            orderQueryBuilder.Append($"{objectProperty.Name} {direction}, ");
        }

        var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');
        if (string.IsNullOrWhiteSpace(orderQuery))
            return customer.OrderBy(c => c.LastName);

        return customer.OrderBy(orderQuery);
    }
}
