using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AgateMountainWarehouse.Api.Controllers;

[Route("api/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] PagingParameters pagingParameters)
    {
        var products = await _productRepository.GetProducts(pagingParameters);
        Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(products.MetaData));

        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var product = await _productRepository.GetProductById(id);
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Product product)
    {
        if (product is null)
        {
            return BadRequest();
        }

        await _productRepository.CreateProduct(product);

        return Created("", product);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(Guid id, [FromBody] Product product)
    {
        var dbProduct = await _productRepository.GetProductById(id);
        if (dbProduct is null)
            return NotFound();

        await _productRepository.UpdateProduct(product, dbProduct);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var product = await _productRepository.GetProductById(id);
        if (product is null)
            return NotFound();

        await _productRepository.DeleteProduct(product);

        return NoContent();
    }
}
