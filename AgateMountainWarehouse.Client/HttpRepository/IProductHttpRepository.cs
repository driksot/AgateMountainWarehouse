using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.ViewModels;

namespace AgateMountainWarehouse.Client.HttpRepository;

public interface IProductHttpRepository
{
    Task<PagingResponse<ProductViewModel>> GetProducts(PagingParameters pagingParameters);
    Task CreateProduct(ProductViewModel product);
}
