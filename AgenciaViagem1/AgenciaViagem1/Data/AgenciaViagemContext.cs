using AgenciaViagem1.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciaViagem1.Data;

public class AgenciaViagemContext : DbContext
{
    public AgenciaViagemContext(DbContextOptions<AgenciaViagemContext> options)
        : base(options) { }
    
    public DbSet<Usuario> Usuarios { get; set; }
}