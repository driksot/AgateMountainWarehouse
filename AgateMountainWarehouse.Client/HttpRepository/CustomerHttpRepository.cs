using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Client.Features;
using AgateMountainWarehouse.Client.Static;
using AgateMountainWarehouse.Client.ViewModels;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Json;

namespace AgateMountainWarehouse.Client.HttpRepository;

public class CustomerHttpRepository : ICustomerHttpRepository
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public CustomerHttpRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public async Task ArchiveCustomer(Guid id)
    {
        var url = Path.Combine(APIEndpoints._customers, id.ToString());

        var patchResult = await _httpClient.PatchAsync(url, null);
        var patchContent = await patchResult.Content.ReadAsStringAsync();

        if (!patchResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(patchContent);
        }
    }

    public async Task CreateCustomer(CustomerViewModel customer)
    {
        var content = JsonSerializer.Serialize(customer);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

        var postResult = await _httpClient.PostAsync(APIEndpoints._customers, bodyContent);
        var postContent = await postResult.Content.ReadAsStringAsync();

        if (!postResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(postContent);
        }
    }

    public async Task DeleteCustomer(Guid id)
    {
        var url = Path.Combine(APIEndpoints._customers, id.ToString());

        var deleteResult = await _httpClient.DeleteAsync(url);
        var deleteContent = await deleteResult.Content.ReadAsStringAsync();

        if (!deleteResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(deleteContent);
        }
    }

    public async Task<CustomerViewModel> GetCustomerById(string id)
    {
        var url = Path.Combine(APIEndpoints._customers, id);

        var response = await _httpClient.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content);
        }

        var customer = JsonSerializer.Deserialize<CustomerViewModel>(content, _options);
        return customer;
    }

    public async Task<PagingResponse<CustomerViewModel>> GetCustomers(PagingParameters pagingParameters)
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

        var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString(APIEndpoints._customers, queryStringParam));
        var content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new ApplicationException(content); // TODO: Handle exception
        }

        var responseItems = JsonSerializer.Deserialize<List<CustomerViewModel>>(content, _options);
        var responseData = JsonSerializer.Deserialize<PagingMetaData>(
                response.Headers.GetValues("X-Pagination").First(),
                _options);

        if (responseItems is null || responseData is null)
        {
            throw new Exception(); // TODO: Handle exception
        }

        var pagingResponse = new PagingResponse<CustomerViewModel>
        {
            Items = responseItems,
            MetaData = responseData
        };

        return pagingResponse;
    }

    public async Task UpdateCustomer(CustomerViewModel customer)
    {
        var content = JsonSerializer.Serialize(customer);
        var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
        var url = Path.Combine(APIEndpoints._customers, customer.Id.ToString());

        var putResult = await _httpClient.PutAsync(url, bodyContent);
        var putContent = await putResult.Content.ReadAsStringAsync();

        if (!putResult.IsSuccessStatusCode)
        {
            throw new ApplicationException(putContent);
        }
    }
}
