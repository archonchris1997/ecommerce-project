using WebApplication1.Data;
using WebApplication1.Models.Models.DTO;

namespace WebApplication1.Services;

public class FiltersService
{
    private readonly AppDbContext _db;
    public FiltersService(AppDbContext db)
    {
        _db = db;
    }
    
    public async Task<CascadeFiltersResponseDto> GetCascadeAsync(CascadeFiltersQuery query, CancellationToken cancellationToken)

}