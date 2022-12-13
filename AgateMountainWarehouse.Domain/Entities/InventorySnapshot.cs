using AgateMountainWarehouse.Domain.Common;

namespace AgateMountainWarehouse.Domain.Entities;

public class InventorySnapshot : AuditableEntity
{
    public Guid InventoryId { get; set; }
    public Inventory? Inventory { get; set; }
    public DateTime SnapshotTime { get; set; }
    public int SnapshotQuantity { get; set; }
}
