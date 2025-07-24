using Microsoft.EntityFrameworkCore;
using TesteAgencia.Models;

namespace TesteAgencia.Data
{
    public class TestAgenciaContext : DbContext
    {
        public TestAgenciaContext(DbContextOptions<TestAgenciaContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}

