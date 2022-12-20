namespace AgateMountainWarehouse.Api.Dtos;

public class InventorySnapshotDto
{
    public Guid ProductId { get; set; }
    public List<int> QuantityOnHand { get; set; } = new List<int>();
}
