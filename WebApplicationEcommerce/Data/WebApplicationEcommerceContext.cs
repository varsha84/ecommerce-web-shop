
using WebApplicationEcommerce.Models;
using Microsoft.EntityFrameworkCore;

//using MySql.EntityFrameworkCore;


namespace WebApplicationEcommerce.Data;

public class WebApplicationEcommerceContext : DbContext

{
    public WebApplicationEcommerceContext(DbContextOptions<WebApplicationEcommerceContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseMySQL("server=localhost;database=productdb;user=root;password=root");
        optionsBuilder.UseSqlServer("server=.;database=productdb;trusted_connection=true;");
    }
}
     

