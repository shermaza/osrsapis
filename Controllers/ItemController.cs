using DpsCalculator.WikiService;
using DpsCalculator.WikiService.ItemService;
using Microsoft.AspNetCore.Mvc;

namespace DpsCalculator.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{

    private readonly ILogger<ItemController> _logger;

    public ItemController(ILogger<ItemController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("{itemId:int}")]
    public Item.Item? Get(int itemId)
    {
        var service = new WikiItemService(new WikiHtmlService());
        return service.Get(itemId);
    }
}