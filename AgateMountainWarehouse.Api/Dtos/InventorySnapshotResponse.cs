namespace AgateMountainWarehouse.Api.Dtos;

public class InventorySnapshotResponse
{
    public List<InventorySnapshotDto> InventorySnapshots { get; set; } = new List<InventorySnapshotDto>();
    public List<DateTime> Timeline { get; set; } = new List<DateTime>();
}
