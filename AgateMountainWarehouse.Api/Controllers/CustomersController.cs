using AgateMountainWarehouse.Api.Errors;
using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AgateMountainWarehouse.Api.Controllers;

[Route("api/customers")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerRepository _customerRepository;

    public CustomersController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get([FromQuery] PagingParameters pagingParameters)
    {
        var customers = await _customerRepository.GetCustomers(pagingParameters);
        if (customers is null) return NotFound(new ApiResponse(404));
        Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(customers.MetaData));

        return Ok(customers);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        var customer = await _customerRepository.GetCustomerById(id);
        if (customer is null) return NotFound(new ApiResponse(404));

        return Ok(customer);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] Customer customer)
    {
        if (customer is null) return BadRequest(new ApiResponse(400));

        await _customerRepository.CreateCustomer(customer);

        return Created("", customer);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] Customer customer)
    {
        var dbCustomer = await _customerRepository.GetCustomerById(id);
        if (dbCustomer is null) return NotFound(new ApiResponse(404));

        await _customerRepository.UpdateCustomer(customer, dbCustomer);

        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id)
    {
        var customer = await _customerRepository.GetCustomerById(id);
        if (customer is null) return NotFound(new ApiResponse(404));

        await _customerRepository.DeleteCustomer(customer);

        return NoContent();
    }
}
