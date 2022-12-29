namespace AgateMountainWarehouse.Client.ViewModels;

public class SnapshotViewModel
{
    public Guid ProductId { get; set; }
    public double[] QuantityOnHand { get; set; } = new double[0];
}
