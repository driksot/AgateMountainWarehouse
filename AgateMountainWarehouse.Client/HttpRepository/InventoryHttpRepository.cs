using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.Static;
using AgateMountainWarehouse.Client.ViewModels;
using AgateMountainWarehouse.Domain.Entities;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;

namespace AgateMountainWarehouse.Client.HttpRepository;

public class InventoryHttpRepository : IInventoryHttpRepository
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public InventoryHttpRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task DeleteInventory(Guid inventoryId)
    {
        var url = Path.Combine(APIEndpoints._inventories, inventoryId.ToString());

        var deleteResult = await _httpClient.DeleteAsync(url);
        var deleteContent = await deleteResult.Content.ReadAsStringAsync();

        if (!deleteResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(deleteContent);
        }
    }

    public async Task<PagingResponse<InventoryViewModel>> GetInventories(PagingParameters pagingParameters)
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

        var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString(APIEndpoints._inventories, queryStringParam));
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }

        var responseItems = JsonSerializer.Deserialize<List<InventoryViewModel>>(content, _options);
        var responseData = JsonSerializer.Deserialize<PagingMetaData>(
            response.Headers.GetValues("X-Pagination").First(), 
            _options);

        if (responseItems is null || responseData is null)
        {
            throw new Exception();
        }

        var pagingResponse = new PagingResponse<InventoryViewModel>
        {
            Items = responseItems,
            MetaData = responseData
        };

        return pagingResponse;
    }

    public async Task<InventoryViewModel> GetInventoryByProductId(string productId)
    {
        var url = Path.Combine(APIEndpoints._inventories, productId);

        var response = await _httpClient.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }

        var inventory = JsonSerializer.Deserialize<InventoryViewModel>(content, _options);
        return inventory;
    }

    public async Task<SnapshotResponseViewModel> GetSnapshotHistory()
    {
        var url = Path.Combine(APIEndpoints._inventories, "snapshot");

        var response = await _httpClient.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }

        var snapshots = JsonSerializer.Deserialize<SnapshotResponseViewModel>(content, _options);
        return snapshots;
    }

    public async Task UpdateQuantityOnHand(InventoryAdjustmentViewModel inventoryAdjustment)
    {
        var content = JsonSerializer.Serialize(inventoryAdjustment);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

        var patchResult = await _httpClient.PatchAsync(APIEndpoints._inventories, bodyContent);
        var patchContent = await patchResult.Content.ReadAsStringAsync();

        if (!patchResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(patchContent);
        }
    }
}
