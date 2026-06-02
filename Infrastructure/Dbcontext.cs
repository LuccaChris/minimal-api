using Microsoft.EntityFrameworkCore;
using minimal_api.Domain.Entities;

namespace minimalApi.Infrastructure.Db;


public class Dbcontext : DbContext
{
    public DbSet<Administrador> Administradores { get; set; } = default!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("MyDatabase", 
        ServerVersion.AutoDetect("MyDatabase"));;
    }
}
