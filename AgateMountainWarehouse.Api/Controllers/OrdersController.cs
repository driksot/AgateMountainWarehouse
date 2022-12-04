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
    public async Task<IActionResult> Get([FromQuery] PagingParameters pagingParameters)
    {
        var orders = await _salesOrderRepository.GetOrders(pagingParameters);
        Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(orders.MetaData));

        return Ok(orders);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var order = await _salesOrderRepository.GetOrderById(id);

        return Ok(order);
    }

    [HttpPost]
    public async Task<IActionResult> Generate([FromBody] SalesOrder order)
    {
        if (order is null)
            return BadRequest();

        await _salesOrderRepository.GenerateOrder(order);

        return Created("", order);
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> MarkFulfilled(Guid id)
    {
        await _salesOrderRepository.MarkFulfilled(id);
        return NoContent();
    }
}
