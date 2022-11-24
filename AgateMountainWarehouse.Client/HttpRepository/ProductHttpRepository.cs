using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.ViewModels;
using Microsoft.AspNetCore.WebUtilities;
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
}
