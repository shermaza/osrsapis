namespace DpsCalculator.WikiService.ItemService;

public interface IItemService
{
    public Item.Item? Get(int id);
    public Item.Item? Get(CacheItem.CacheItem id);
}