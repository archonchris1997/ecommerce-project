using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Models.DTO;

namespace WebApplication1.Controllers;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;


[ApiController]
[Route("api/filtros")]
public class FiltrosController: ControllerBase
{
    private readonly AppDbContext _db;
    public FiltrosController(AppDbContext db) => _db = db;

    [HttpGet("cascade")]
    public async Task<ActionResult<CascadeFiltersResponse>> GetCascade(
        [FromQuery] string? categoria,
        [FromQuery] string? marca,
        [FromQuery] string? modelo,
        [FromQuery] int? ano,
        [FromQuery] string? cor,
        [FromQuery] int? armazenamentoGB,
        [FromQuery] int? ramGB,
        [FromQuery] string? condicao,
        CancellationToken ct)
    {
        
        
    }


}