using System.ComponentModel.DataAnnotations;

namespace AgateMountainWarehouse.Client.ViewModels;

public class InvoiceViewModel
{
    public Guid CustomerId { get; set; }
    public bool IsPaid { get; set; } = false;
    public double TotalCost { get; set; }
    public List<LineItemViewModel> LineItems { get; set; } = new List<LineItemViewModel>();
    public DateTime CreatedDateTime { get; set; }
    public DateTime? UpdatedDateTime { get; set; }
}

public class LineItemViewModel
{
    [Required(ErrorMessage = "Product is a required field")]
    public ProductViewModel Product { get; set; } = new ProductViewModel();

    [Required(ErrorMessage = "Quantity is a required field")]
    [Range(1, int.MaxValue, ErrorMessage = "The quantity can't be lower than 1")]
    public int Quantity { get; set; }
}
