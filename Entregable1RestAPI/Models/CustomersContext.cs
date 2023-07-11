using Microsoft.EntityFrameworkCore;
namespace Entregable1RestAPI.Models
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions<CustomersContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; } = null!;
    }
}
