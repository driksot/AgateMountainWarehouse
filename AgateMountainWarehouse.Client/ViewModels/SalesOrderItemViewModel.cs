namespace AgateMountainWarehouse.Client.ViewModels;

public class SalesOrderItemViewModel
{
    public Guid Id { get; set; }
    public ProductViewModel Product { get; set; } = new ProductViewModel();
    public int Quantity { get; set; }
}
