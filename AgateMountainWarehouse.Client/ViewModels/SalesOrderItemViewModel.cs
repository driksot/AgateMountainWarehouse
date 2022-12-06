using System.ComponentModel.DataAnnotations;

namespace AgateMountainWarehouse.Client.ViewModels;

public class SalesOrderItemViewModel
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Product is a required field")]
    public ProductViewModel Product { get; set; } = new ProductViewModel();

    [Required(ErrorMessage = "Quantity is a required field")]
    [Range(1, int.MaxValue, ErrorMessage = "The quantity can't be lower than 1")]
    public int Quantity { get; set; }
}
