using AgateMountainWarehouse.Domain.Common;

namespace AgateMountainWarehouse.Domain.Entities;

public class InventorySnapshot : AuditableEntity
{
    public Product Product { get; set; } = null!;
    public DateTime SnapshotTime { get; set; }
    public int SnapshotQuantity { get; set; }
}
