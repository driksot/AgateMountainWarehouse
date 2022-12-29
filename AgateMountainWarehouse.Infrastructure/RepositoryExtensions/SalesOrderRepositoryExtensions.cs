using AgateMountainWarehouse.Domain.Entities;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace AgateMountainWarehouse.Infrastructure.RepositoryExtensions;

public static class SalesOrderRepositoryExtensions
{
    public static IQueryable<SalesOrder> Search(this IQueryable<SalesOrder> salesOrders, string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return salesOrders;
        var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
        return salesOrders.Where(so => so.Id.ToString().Contains(lowerCaseSearchTerm));
    }

    public static IQueryable<SalesOrder> Sort(this IQueryable<SalesOrder> salesOrders, string orderByQueryString)
    {
        if (string.IsNullOrWhiteSpace(orderByQueryString))
            return salesOrders;

        var orderParams = orderByQueryString.Trim().Split(',');
        var propertyInfos = typeof(SalesOrder).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var orderQueryBuilder = new StringBuilder();

        foreach (var param in orderParams)
        {
            if (string.IsNullOrWhiteSpace(param))
                continue;

            var propertyFromQueryName = param.Split(" ")[0];
            var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

            if (objectProperty is null)
                continue;

            var direction = param.EndsWith(" desc") ? "descending" : "ascending";
            orderQueryBuilder.Append($"{objectProperty.Name} {direction}, ");
        }

        var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');
        if (string.IsNullOrWhiteSpace(orderQuery))
            return salesOrders;

        return salesOrders.OrderBy(orderQuery);
    }
}
