using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
    
    public DbSet<Produto>Produtos =>  Set<Produto>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasIndex(p => new
        {
            p.Categoria, p.Marca, p.Modelo, p.Preco, p.Nome, p.Cor, p.ArmazenamentoGB, p.RamGB, p.Condicao
        });
        
        base.OnModelCreating(modelBuilder);
    }
    
    
}