using Microsoft.AspNetCore.Mvc;
using ApiBoletos.Controllers;

namespace ApiBoletos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoletosController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Lista de Boletos");
    }
}