using AgateMountainWarehouse.Domain.Common;

namespace AgateMountainWarehouse.Domain.Entities;

public class Inventory : AuditableEntity
{
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
    public int QuantityOnHand { get; set; }
}
