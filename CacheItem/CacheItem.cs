using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DpsCalculator.CacheItem;

public class CacheItem
{
    public int Id { get; set; }
    public bool IsNoted { get; set; }
    public bool IsStackable { get; set; }
    public bool IsMembers { get; set; }
    public string? Name { get; set; }

    public static List<CacheItem> GetAllFromFile()
    {
        var files = new[] {
            "ItemDefinitions/items1.json",
            "ItemDefinitions/items2.json"
        };

        var items = new List<CacheItem>();

        foreach (var file in files)
        {
            using (var r = new StreamReader("CacheItem/ItemDefinitions/items1.json"))
            {
                var json = r.ReadToEnd();
                var parsed = JsonConvert.DeserializeObject(json);

                foreach (JProperty obj in (JToken) parsed)
                {
                    var item = new CacheItem();
                    item.Id = int.Parse(obj.Name);
                    item.IsNoted = (bool) (obj.Value["noted"] ?? false);
                    item.IsStackable = (bool) (obj.Value["stackable"] ?? false);
                    item.IsMembers = (bool) (obj.Value["members"] ?? false);
                    item.Name = (string) obj.Value["name"] ?? string.Empty;
                    items.Add(item);
                }
            }
        }
        
        return items;

    }
}