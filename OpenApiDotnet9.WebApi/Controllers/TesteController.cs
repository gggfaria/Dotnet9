using Microsoft.AspNetCore.Mvc;
using OpenApiDotnet9.WebApi.Models;
using OpenApiDotnet9.WebApi.Repositories;

namespace OpenApiDotnet9.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TesteController : ControllerBase
{
    private readonly TesteRepository _testeRepository;
    
    public TesteController(TesteRepository testeRepository)
    {
        _testeRepository = testeRepository;
    }
    
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Teste>), StatusCodes.Status200OK)]
    public IActionResult Index()
    {
        return Ok(_testeRepository.GetTestes());
    }

    [HttpPost]
    [ProducesResponseType(typeof(Teste), StatusCodes.Status201Created)]
    public IActionResult Post([FromBody] Teste teste)
    {
        _testeRepository.InsertTeste(teste);
        return StatusCode(StatusCodes.Status201Created, teste);
    }
    
    [HttpGet("/{id}")]
    [ProducesResponseType(typeof(IEnumerable<Teste>), StatusCodes.Status200OK)]
    public IActionResult Index(Guid id)
    {
        return Ok(_testeRepository.GetTestes(id));
    }
    
}