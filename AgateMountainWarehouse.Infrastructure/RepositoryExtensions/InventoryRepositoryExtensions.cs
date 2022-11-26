using AgateMountainWarehouse.Domain.Entities;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace AgateMountainWarehouse.Infrastructure.RepositoryExtensions;

public static class InventoryRepositoryExtensions
{
    public static IQueryable<Inventory> Search(this IQueryable<Inventory> inventories, string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return inventories;
        var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
        return inventories.Where(p => p.Product.Name.ToLower().Contains(lowerCaseSearchTerm));
    }

    public static IQueryable<Inventory> Sort(this IQueryable<Inventory> inventories, string orderByQueryString)
    {
        if (string.IsNullOrWhiteSpace(orderByQueryString))
            return inventories.OrderBy(e => e.Product.Name);

        var orderParams = orderByQueryString.Trim().Split(',');
        var propertyInfos = typeof(Inventory).GetProperties(BindingFlags.Public | BindingFlags.Instance);
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
            return inventories.OrderBy(e => e.Product.Name);

        return inventories.OrderBy(orderQuery);
    }
}
