using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.Static;
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

    public async Task ArchiveProduct(Guid id)
    {
        var url = Path.Combine(APIEndpoints._products, id.ToString());

        var patchResult = await _httpClient.PatchAsync(url, null);
        var patchContent = await patchResult.Content.ReadAsStringAsync();

        if (!patchResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(patchContent);
        }
    }

    public async Task CreateProduct(ProductViewModel product)
    {
        var content = JsonSerializer.Serialize(product);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

        var postResult = await _httpClient.PostAsync(APIEndpoints._products, bodyContent);
        var postContent = await postResult.Content.ReadAsStringAsync();

        if (!postResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(postContent);
        }
    }

    public async Task DeleteProduct(Guid id)
    {
        var url = Path.Combine(APIEndpoints._products, id.ToString());

        var deleteResult = await _httpClient.DeleteAsync(url);
        var deleteContent = await deleteResult.Content.ReadAsStringAsync();

        if (!deleteResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(deleteContent);
        }
    }

    public async Task<ProductViewModel> GetProductById(string id)
    {
        var url = Path.Combine(APIEndpoints._products, id);

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
            ["pageNumber"] = pagingParameters.PageNumber.ToString(),
            ["pageSize"] = pagingParameters.PageSize.ToString()
        };

        if (pagingParameters.SearchTerm.Any())
        {
            queryStringParam.Add("searchTerm", pagingParameters.SearchTerm);
        }

        if (pagingParameters.OrderBy.Any())
        {
            queryStringParam.Add("orderBy", pagingParameters.OrderBy);
        }

        var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString(APIEndpoints._products, queryStringParam));
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
        var url = Path.Combine(APIEndpoints._products, product.Id.ToString());

        var putResult = await _httpClient.PutAsync(url, bodyContent);
        var putContent = await putResult.Content.ReadAsStringAsync();

        if (!putResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(putContent);
        }
    }

    public async Task<string> UploadProductImage(MultipartFormDataContent content)
    {
        var postResult = await _httpClient.PostAsync("api/upload", content);
        var postContent = await postResult.Content.ReadAsStringAsync();

        if (!postResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(postContent);
        }
        else
        {
            var imgUrl = postContent;
            return imgUrl;
        }
    }
}
