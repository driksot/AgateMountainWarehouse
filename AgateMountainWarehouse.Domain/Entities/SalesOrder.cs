using AgateMountainWarehouse.Domain.Common;

namespace AgateMountainWarehouse.Domain.Entities;

public class SalesOrder : AuditableEntity
{
    public Guid CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public bool IsPaid { get; set; } = false;
    public double TotalCost { get; set; }
    public List<SalesOrderItem> OrderItems { get; set; } = new List<SalesOrderItem>();
}
