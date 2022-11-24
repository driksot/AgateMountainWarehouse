using AgateMountainWarehouse.Client.ViewModels;

namespace AgateMountainWarehouse.Client.HttpRepository;

public interface IProductHttpRepository
{
    Task<List<ProductViewModel>> GetProducts();
}
