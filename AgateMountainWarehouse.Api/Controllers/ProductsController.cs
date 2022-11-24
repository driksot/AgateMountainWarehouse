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
}
