using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.ViewModels;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;

namespace AgateMountainWarehouse.Client.HttpRepository;

public class ProductHttpRepository : IProductHttpRepository
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public ProductHttpRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task CreateProduct(ProductViewModel product)
    {
        var content = JsonSerializer.Serialize(product);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

        var postResult = await _httpClient.PostAsync("products", bodyContent);
        var postContent = await postResult.Content.ReadAsStringAsync();

        if (!postResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(postContent);
        }
    }

    public async Task DeleteProduct(Guid id)
    {
        var url = Path.Combine("products", id.ToString());

        var deleteResult = await _httpClient.DeleteAsync(url);
        var deleteContent = await deleteResult.Content.ReadAsStringAsync();

        if (!deleteResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(deleteContent);
        }
    }

    public async Task<ProductViewModel> GetProductById(string id)
    {
        var url = Path.Combine("products", id);

        var response = await _httpClient.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }

        var product = JsonSerializer.Deserialize<ProductViewModel>(content, _options);
        return product;
    }

    public async Task<PagingResponse<ProductViewModel>> GetProducts(PagingParameters pagingParameters)
    {
        var queryStringParam = new Dictionary<string, string?>
        {
            ["pageNumber"] = pagingParameters.PageNumber.ToString()
        };

        if (pagingParameters.SearchTerm.Any())
        {
            queryStringParam.Add("searchTerm", pagingParameters.SearchTerm);
        }

        if (pagingParameters.OrderBy.Any())
        {
            queryStringParam.Add("orderBy", pagingParameters.OrderBy);
        }

        var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString("products", queryStringParam));
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content); // TODO: Handle exception
        }

        var responseItems = JsonSerializer.Deserialize<List<ProductViewModel>>(content, _options);
        var responseData = JsonSerializer.Deserialize<PagingMetaData>(
                response.Headers.GetValues("X-Pagination").First(),
                _options);

        if (responseItems is null || responseData is null)
        {
            throw new Exception(); // TODO: Handle exception
        }

        var pagingResponse = new PagingResponse<ProductViewModel>
        {
            Items = responseItems,
            MetaData = responseData
        };

        return pagingResponse;
    }

    public async Task UpdateProduct(ProductViewModel product)
    {
        var content = JsonSerializer.Serialize(product);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
        var url = Path.Combine("products", product.Id.ToString());

        var putResult = await _httpClient.PutAsync(url, bodyContent);
        var putContent = await putResult.Content.ReadAsStringAsync();

        if (!putResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(putContent);
        }
    }

    public async Task<string> UploadProductImage(MultipartFormDataContent content)
    {
        var postResult = await _httpClient.PostAsync("upload", content);
        var postContent = await postResult.Content.ReadAsStringAsync();

        if (!postResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(postContent);
        }
        else
        {
            var imgUrl = Path.Combine("https://localhost:7252/", postContent);
            return imgUrl;
        }
    }
}
