using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.ViewModels;

namespace AgateMountainWarehouse.Client.HttpRepository;

public interface IProductHttpRepository
{
    Task<PagingResponse<ProductViewModel>> GetProducts(PagingParameters pagingParameters);
    Task<ProductViewModel> GetProductById(string id);
    Task CreateProduct(ProductViewModel product);
    Task<string> UploadProductImage(MultipartFormDataContent content);
    Task UpdateProduct(ProductViewModel product);
    Task DeleteProduct(Guid id);
    Task ArchiveProduct(Guid id);
}
