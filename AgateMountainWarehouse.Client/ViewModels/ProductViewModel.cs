using System.ComponentModel.DataAnnotations;

namespace AgateMountainWarehouse.Client.ViewModels;

public class ProductViewModel
{
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Name is a required field")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "Description is a required field")]
    public string Description { get; set; } = string.Empty;
    [Required(ErrorMessage = "Price is a required field")]
    [Range(1, double.MaxValue, ErrorMessage = "Value for the price can't be lower than 1")]
    public double Price { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public DateTime CreatedDateTime { get; set; }
    public DateTime? UpdatedDateTime { get; set; }
}
