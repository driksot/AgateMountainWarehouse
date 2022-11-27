namespace AgateMountainWarehouse.Client.ViewModels
{
    public class InventoryViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public ProductViewModel? Product { get; set; }
        public int QuantityOnHand { get; set; }
    }
}
