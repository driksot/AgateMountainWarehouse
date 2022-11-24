using AgateMountainWarehouse.Domain.Entities;

namespace AgateMountainWarehouse.Infrastructure.RepositoryExtensions;

public static class ProductRepositoryExtensions
{
    public static IQueryable<Product> Search(this IQueryable<Product> products, string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return products;
        var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
        return products.Where(p => p.Name.ToLower().Contains(lowerCaseSearchTerm));
    }
}
