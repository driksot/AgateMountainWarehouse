using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.ViewModels;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;

namespace AgateMountainWarehouse.Client.HttpRepository;

public class OrderHttpRepository : IOrderHttpRepository
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public OrderHttpRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task GenerateOrder(SalesOrderViewModel order)
    {
        var content = JsonSerializer.Serialize(order);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

        var postResult = await _httpClient.PostAsync("orders", bodyContent);
        var postContent = await postResult.Content.ReadAsStringAsync();

        if (!postResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(postContent);
        }
    }

    public async Task<SalesOrderViewModel> GetOrderById(string orderId)
    {
        var url = Path.Combine("orders", orderId);

        var response = await _httpClient.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }

        var order = JsonSerializer.Deserialize<SalesOrderViewModel>(content, _options);
        return order;
    }

    public async Task<PagingResponse<SalesOrderViewModel>> GetOrders(PagingParameters pagingParameters)
    {
        var queryStringParam = new Dictionary<string, string?>
        {
            ["pageNumber"] = pagingParameters.PageNumber.ToString()
        };

        var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString("orders", queryStringParam));
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }

        var responseItems = JsonSerializer.Deserialize<List<SalesOrderViewModel>>(content, _options);
        var responseData = JsonSerializer.Deserialize<PagingMetaData>(
            response.Headers.GetValues("X-Pagination").First(), 
            _options);

        if (responseItems is null || responseData is null)
        {
            throw new Exception();
        }

        var pagingResponse = new PagingResponse<SalesOrderViewModel>
        {
            Items = responseItems,
            MetaData = responseData
        };

        return pagingResponse;
    }

    public async Task MarkFulfilled(Guid orderId)
    {
        var url = Path.Combine("orders", orderId.ToString());

        var patchResult = await _httpClient.PatchAsync(url, null);
        var patchContent = await patchResult.Content.ReadAsStringAsync();

        if (!patchResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(patchContent);
        }
    }
}
