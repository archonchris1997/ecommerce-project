using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Models.DTO;
using WebApplication1.Services;

namespace WebApplication1.Controllers;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;


[ApiController]
[Route("api/filtros")]
public class FiltrosController: ControllerBase
{
    private readonly FiltersService _service;
    
    
    


}