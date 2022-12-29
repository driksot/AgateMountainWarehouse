using AgateMountainWarehouse.Domain.Common;

namespace AgateMountainWarehouse.Domain.Entities;

public class Product : AuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public bool IsArchived { get; set; } = false;
}
