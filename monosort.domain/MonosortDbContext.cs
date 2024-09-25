using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using monosort.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monosort.domain;

public class MonosortDbContext : IdentityDbContext
{
    public MonosortDbContext(DbContextOptions options) : base(options)
    {

    }

    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<ProductInventory> ProductsInventory { get; set; }
    public virtual DbSet<ProductInventorySnapshot> ProductsInventorySnapshot { get; set;}
    public virtual DbSet<SalesOrder> SalesOrders { get; set; }
    public virtual DbSet<SalesOrderItem> SalesOrdersItem { get; set;}
}
