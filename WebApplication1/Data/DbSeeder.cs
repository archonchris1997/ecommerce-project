using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public static class DbSeeder
{
    public static async Task SeedAsync(AppDbContext db)
    {
        await db.Database.MigrateAsync();

        if (await db.Produtos.AnyAsync())
            return;

        db.Produtos.AddRange(
            new Produto { Id = Guid.NewGuid(), Nome="iPhone 13 128GB Preto", Categoria="Telemóveis", Preco=550,
                Marca="Apple", Modelo="iPhone 13", Ano=2021, Cor="Preto", ArmazenamentoGB=128, RamGB=4, Condicao="Recondicionado" },

            new Produto { Id = Guid.NewGuid(), Nome="iPhone 13 256GB Branco", Categoria="Telemóveis", Preco=620,
                Marca="Apple", Modelo="iPhone 13", Ano=2021, Cor="Branco", ArmazenamentoGB=256, RamGB=4, Condicao="Recondicionado" },

            new Produto { Id = Guid.NewGuid(), Nome="Galaxy S22 128GB Preto", Categoria="Telemóveis", Preco=500,
                Marca="Samsung", Modelo="Galaxy S22", Ano=2022, Cor="Preto", ArmazenamentoGB=128, RamGB=8, Condicao="Novo" },

            new Produto { Id = Guid.NewGuid(), Nome="Xiaomi 12 256GB Azul", Categoria="Telemóveis", Preco=420,
                Marca="Xiaomi", Modelo="Xiaomi 12", Ano=2022, Cor="Azul", ArmazenamentoGB=256, RamGB=8, Condicao="Novo" }
        );

        await db.SaveChangesAsync();
    }
}