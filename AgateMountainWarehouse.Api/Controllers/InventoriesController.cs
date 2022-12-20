using AgateMountainWarehouse.Api.Dtos;
using AgateMountainWarehouse.Api.Errors;
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
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get([FromQuery] PagingParameters pagingParameters)
    {
        var inventories = await _inventoryRepository.GetInventories(pagingParameters);
        if (inventories is null) return NotFound(new ApiResponse(404));
        Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(inventories.MetaData));

        return Ok(inventories);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetByProductId(Guid id)
    {
        var inventory = await _inventoryRepository.GetInventoryByProductId(id);
        if (inventory is null) return NotFound(new ApiResponse(404));

        return Ok(inventory);
    }

    [HttpPatch]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateQuantity([FromBody] InventoryAdjustment inventoryAdjustment)
    {
        if (!ModelState.IsValid) return BadRequest(new ApiResponse(400));

        var id = inventoryAdjustment.InventoryId;
        var adjustment = inventoryAdjustment.Adjustment;

        await _inventoryRepository.UpdateQuantityOnHand(id, adjustment);

        return NoContent();
    }

    [HttpGet("snapshot")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetSnapshotHistory()
    {
        try
        {
            var snapshotHistory = await _inventoryRepository.GetSnapshotHistory();

            var timelinePoints = snapshotHistory
                .Select(snapshot => snapshot.SnapshotTime)
                .Distinct()
                .ToList();

            var groupedSnapshots = snapshotHistory
                .GroupBy(snapshot => snapshot.Product, snapshot => snapshot.SnapshotQuantity,
                    (key, g) => new InventorySnapshotDto
                    {
                        ProductId = key.Id,
                        QuantityOnHand = g.ToList()
                    })
                .OrderBy(snapshot => snapshot.ProductId)
                .ToList();

            var response = new InventorySnapshotResponse
            {
                Timeline = timelinePoints,
                InventorySnapshots = groupedSnapshots
            };

            return Ok(response);
        }
        catch (Exception)
        {
            return BadRequest(new ApiResponse(400));
        }
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id)
    {
        var inventory = await _inventoryRepository.GetInventoryById(id);
        if (inventory is null) return NotFound(new ApiResponse(404));

        await _inventoryRepository.DeleteInventory(inventory);

        return NoContent();
    }
}
