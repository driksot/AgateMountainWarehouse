using AgateMountainWarehouse.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
    public async Task<IActionResult> Get()
    {
        var products = await _productRepository.GetProducts();
        return Ok(products);
    }
}
