namespace AgateMountainWarehouse.Client.ViewModels;

public class SalesOrderViewModel
{
    public Guid Id { get; set; }
    public bool IsPaid { get; set; } = false;
    public int TotalCost { get; set; }
    public List<SalesOrderItemViewModel> OrderItems { get; set; } = new List<SalesOrderItemViewModel>();
    public DateTime CreatedDateTime { get; set; }
    public DateTime? UpdatedDateTime { get; set; }
}
