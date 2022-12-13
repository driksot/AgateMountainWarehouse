using AgateMountainWarehouse.Domain.Common;
using AgateMountainWarehouse.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgateMountainWarehouse.Infrastructure;

public class WarehouseDbContext : IdentityDbContext<User>
{
	public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(WarehouseDbContext).Assembly);
	}

	public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            entry.Entity.UpdatedDateTime = DateTime.Now;

            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedDateTime = DateTime.Now;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<SalesOrder> SalesOrders { get; set; }
    public DbSet<SalesOrderItem> SalesOrderItems { get; set; }
}
