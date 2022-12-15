namespace AgateMountainWarehouse.Client.ViewModels;

public class CustomerViewModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public CustomerAddressViewModel Address { get; set; } = new CustomerAddressViewModel();
    public DateTime CreatedDateTime { get; set; }
    public DateTime? UpdatedDateTime { get; set; }
}
