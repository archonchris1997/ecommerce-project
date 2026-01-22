namespace WebApplication1.Data;

public class Produto
{
    public Guid Id { get; set; }

    public string Nome { get; set; } = "";
    public string Categoria { get; set; } = "Telemóveis";

    public decimal Preco { get; set; }
    public string Moeda { get; set; } = "EUR";

    // ✅ Campos para Cascade Filters
    public string Marca { get; set; } = "";
    public string Modelo { get; set; } = "";
    public int Ano { get; set; }
    public string Cor { get; set; } = "";
    public int ArmazenamentoGB { get; set; }
    public int RamGB { get; set; }
    public string Condicao { get; set; } = ""; // Novo, Recondicionado

    // para fases futuras
    public int StockDisponivel { get; set; }
    public int StockReservado { get; set; }
}