using System.ComponentModel.DataAnnotations;

namespace AgateMountainWarehouse.Client.ViewModels
{
    public class InventoryViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public ProductViewModel? Product { get; set; }

        [Required(ErrorMessage = "Quantity is a required field")]
        [Range(0, int.MaxValue, ErrorMessage = "The quantity can't be lower than 0")]
        public int QuantityOnHand { get; set; }
    }
}
