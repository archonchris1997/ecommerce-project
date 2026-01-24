namespace WebApplication1.Models.Models.DTO;

public record FilterOption(string Value, int Count);

public record CascadeFiltersResponse(  List<FilterOption> Marcas,
    List<FilterOption> Modelos,
    List<FilterOption> Anos,
    List<FilterOption> Cores,
    List<FilterOption> Armazenamentos,
    List<FilterOption> Rams,
    List<FilterOption> Condicoes
);