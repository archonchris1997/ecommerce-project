namespace WebApplication1.Models.Models.DTO;

public class CascadeFiltersResponseDto
{
    public List<FilterOptionDto> Marcas { get; set; } = [];
    public List<FilterOptionDto> Modelos { get; set; } = [];
    public List<FilterOptionDto> Anos { get; set; } = [];
    public List<FilterOptionDto> Cores { get; set; } = [];
    public List<FilterOptionDto> Armazenamentos { get; set; } = [];
    public List<FilterOptionDto> Rams { get; set; } = [];
    public List<FilterOptionDto> Condicoes { get; set; } = [];
}