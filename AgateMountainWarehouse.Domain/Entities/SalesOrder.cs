using AgateMountainWarehouse.Domain.Common;

namespace AgateMountainWarehouse.Domain.Entities;

public class SalesOrder : AuditableEntity
{
    public bool IsPaid { get; set; } = false;
    public List<SalesOrderItem> OrderItems { get; set; } = new List<SalesOrderItem>();
}
