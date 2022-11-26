using AgateMountainWarehouse.Api.Dtos;
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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByProductId(Guid id)
    {
        var inventory = await _inventoryRepository.GetInventoryByProductId(id);
        return Ok(inventory);
    }

    [HttpPatch]
    public async Task<IActionResult> UpdateQuantity([FromBody] InventoryAdjustment inventoryAdjustment)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState);

        var id = inventoryAdjustment.InventoryId;
        var adjustment = inventoryAdjustment.Adjustment;

        await _inventoryRepository.UpdateQuantityOnHand(id, adjustment);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var inventory = await _inventoryRepository.GetInventoryById(id);
        if (inventory is null)
            return NotFound();

        await _inventoryRepository.DeleteInventory(inventory);

        return NoContent();
    }
}
