using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

[ApiController]
[Route("api/produtos")]
public class ProdutosController:ControllerBase
{
    private readonly AppDbContext _db;
    public ProdutosController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken ct)
    {
        var produtos = await _db.Produtos.AsNoTracking().ToListAsync(ct);
        return Ok(produtos);
    }
    
    
}