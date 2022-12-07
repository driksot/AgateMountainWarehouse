using AgateMountainWarehouse.Api.Errors;
using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AgateMountainWarehouse.Api.Controllers;

[Route("api/orders")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly ISalesOrderRepository _salesOrderRepository;

    public OrdersController(ISalesOrderRepository salesOrderRepository)
    {
        _salesOrderRepository = salesOrderRepository;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get([FromQuery] PagingParameters pagingParameters)
    {
        var orders = await _salesOrderRepository.GetOrders(pagingParameters);
        if (orders is null) return NotFound(new ApiResponse(404));
        Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(orders.MetaData));

        return Ok(orders);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        var order = await _salesOrderRepository.GetOrderById(id);
        if (order is null) return NotFound(new ApiResponse(404));

        return Ok(order);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Generate([FromBody] SalesOrder order)
    {
        if (order is null) return BadRequest(new ApiResponse(400));

        await _salesOrderRepository.GenerateOrder(order);

        return Created("", order);
    }

    [HttpPatch("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> MarkFulfilled(Guid id)
    {
        await _salesOrderRepository.MarkFulfilled(id);
        return NoContent();
    }
}
