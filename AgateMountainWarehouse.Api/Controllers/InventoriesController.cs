using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Application.RequestFeatures;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AgateMountainWarehouse.Api.Controllers;

[Route("api/inventories")]
[ApiController]
public class InventoriesController : ControllerBase
{
    private readonly IInventoryRepository _inventoryRepository;

    public InventoriesController(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] PagingParameters pagingParameters)
    {
        var inventories = await _inventoryRepository.GetInventories(pagingParameters);
        Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(inventories.MetaData));

        return Ok(inventories);
    }
}
