using Microsoft.EntityFrameworkCore;
using MVC.NET6_CRUDEntityFramework.Models.Domain;

namespace MVC.NET6_CRUDEntityFramework.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
