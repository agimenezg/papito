using Microsoft.AspNetCore.Mvc;
using Models.papi;

namespace papi.Controllers;

[ApiController]
[Route("[controller]")]
public class BebidaController : ControllerBase
{

    private readonly ILogger<BebidaController> _logger;

    public BebidaController(ILogger<BebidaController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBebidas")]
    public IEnumerable<Bebida> Get()
    {
        return new Bebida();
       
    }
}
