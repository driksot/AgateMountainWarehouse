﻿using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;
using AgateMountainWarehouse.Infrastructure.RepositoryExtensions;
using Microsoft.EntityFrameworkCore;

namespace AgateMountainWarehouse.Infrastructure.Persistence;

public class ProductRepository : IProductRepository
{
    private readonly WarehouseDbContext _context;

    public ProductRepository(WarehouseDbContext context)
    {
        _context = context;
    }

    public async Task<PagedList<Product>> GetProducts(PagingParameters pagingParameters)
    {
        var products = await _context.Products
            .Search(pagingParameters.SearchTerm)
            .ToListAsync();

        return PagedList<Product>.ToPagedList(
            products, 
            pagingParameters.PageNumber, 
            pagingParameters.PageSize);
    }
}
