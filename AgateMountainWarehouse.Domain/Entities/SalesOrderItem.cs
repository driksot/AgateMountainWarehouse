using AgateMountainWarehouse.Domain.Common;

namespace AgateMountainWarehouse.Domain.Entities;

public class SalesOrderItem : AuditableEntity
{
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
    public int Quantity { get; set; }
}
