namespace AgateMountainWarehouse.Client.ViewModels;

public class SnapshotResponseViewModel
{
    public SnapshotViewModel[] InventorySnapshots { get; set; } = new SnapshotViewModel[0];
    public DateTime[] Timeline { get; set; } = new DateTime[0];
}
