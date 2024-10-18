using Microsoft.EntityFrameworkCore;
using StoredProc.Models;


namespace StoredProc.Data
{
    public class StoredProcDbContext : DbContext
    {
        public StoredProcDbContext(DbContextOptions<StoredProcDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
