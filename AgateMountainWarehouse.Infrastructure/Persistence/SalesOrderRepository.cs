﻿using AgateMountainWarehouse.Application.Interfaces;
using AgateMountainWarehouse.Application.RequestFeatures;
using AgateMountainWarehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgateMountainWarehouse.Infrastructure.Persistence;

public class SalesOrderRepository : ISalesOrderRepository
{
    private readonly WarehouseDbContext _context;
    private readonly IProductRepository _productRepository;
    private readonly IInventoryRepository _inventoryRepository;

    public SalesOrderRepository(
        WarehouseDbContext context, 
        IProductRepository productRepository, 
        IInventoryRepository inventoryRepository)
    {
        _context = context;
        _productRepository = productRepository;
        _inventoryRepository = inventoryRepository;
    }

    public async Task GenerateOrder(SalesOrder order)
    {
        foreach (var item in order.OrderItems)
        {
            item.Product = await _productRepository.GetProductById(item.Id);

            // Adjust product inventory quantity
            var inventory = await _inventoryRepository.GetInventoryByProductId(item.Id);
            var adjustment = inventory.QuantityOnHand - item.Quantity;

            await _inventoryRepository.UpdateQuantityOnHand(inventory.Id, adjustment);
        }

        await _context.SalesOrders.AddAsync(order);
        await _context.SaveChangesAsync();
    }

    public async Task<SalesOrder> GetOrderById(Guid orderId)
    {
        return await _context.SalesOrders
            .Include(so => so.OrderItems)
            .ThenInclude(item => item.Product)
            .FirstOrDefaultAsync(so => so.Id.Equals(orderId));
    }

    public async Task<PagedList<SalesOrder>> GetOrders(PagingParameters pagingParameters)
    {
        var orders = await _context.SalesOrders
            .Include(so => so.OrderItems)
            .ThenInclude(item => item.Product)
            .ToListAsync();

        return PagedList<SalesOrder>.ToPagedList(
            orders,
            pagingParameters.PageNumber,
            pagingParameters.PageSize);
    }

    public async Task MarkFulfilled(Guid orderId)
    {
        var order = await _context.SalesOrders.FindAsync(orderId);
        order.IsPaid = true;

        await _context.SaveChangesAsync();
    }
}