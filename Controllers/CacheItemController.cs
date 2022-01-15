using Microsoft.AspNetCore.Mvc;

namespace DpsCalculator.Controllers;

[ApiController]
[Route("[controller]")]
public class CacheItemController : ControllerBase
{

    private readonly ILogger<CacheItemController> _logger;

    public CacheItemController(ILogger<CacheItemController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCacheItems")]
    public IEnumerable<CacheItem.CacheItem> Get()
    {
        return CacheItem.CacheItem.GetAllFromFile();
    }
}