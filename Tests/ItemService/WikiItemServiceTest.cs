using DpsCalculator.Tests.TestFiles;
using DpsCalculator.WikiService;
using DpsCalculator.WikiService.ItemService;
using HtmlAgilityPack;
using Xunit;
using Moq;
using Xunit.Abstractions;

namespace DpsCalculator.Tests.ItemService;

public class WikiItemServiceTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public WikiItemServiceTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    [Trait("Category","Unit")]
    public void Get_Returns_Item_Type()
    {
        int itemId = 0;
        var mockHtmlService = GetMockDocument(new Cannonball(), itemId);
        var wikiItemService = new WikiItemService(mockHtmlService);
        
        var result = wikiItemService.Get(itemId);

        Assert.IsType<Item.Item>(result);
    }

    [Fact]
    [Trait("Category","Unit")]
    public void Get_Returns_Same_Results_For_Int_and_CacheItem()
    {
        const int itemId = 0;
        var mockHtmlService = GetMockDocument(new Cannonball(), itemId);
        var wikiItemService = new WikiItemService(mockHtmlService);

        var cacheItem = new CacheItem.CacheItem
        {
            Id = itemId
        };

        var cacheItemResult = wikiItemService.Get(cacheItem);
        var intResult = wikiItemService.Get(itemId);

        Assert.Equivalent(intResult, cacheItemResult);
    }

    [Fact]
    [Trait("Category","Unit")]
    public void Get_Dwarf_Remains()
    {
        const int itemId = 0;
        var mockHtmlService = GetMockDocument(new DwarfRemains(), itemId);
        var wikiItemService = new WikiItemService(mockHtmlService);

        var result = wikiItemService.Get(itemId);
        
        Assert.Equivalent(itemId, result.Id);
        Assert.Equivalent("Dwarf remains", result.Name);
        Assert.Equivalent(new DateTime(2003, 5, 27), result.ReleaseDate);
        Assert.True(result.IsMembers);
        Assert.False(result.IsTradeable);
        Assert.False(result.IsEquipable);
        Assert.False(result.IsStackable);
        Assert.Equivalent(@"These are the remains of the dwarf who was stationed in the Guard Tower.", result.DestroyText);
        Assert.Equivalent(@"The body of a Dwarf savaged by Goblins.", result.ExamineText);
        Assert.Equivalent(1, result.Value);
        Assert.Equivalent(0, result.HighAlchValue);
        Assert.Equivalent(0, result.LowAlchValue);
        Assert.Equivalent((double)16, result.Weight);
    }

    [Fact]
    [Trait("Category","Unit")]
    public void Get_Toolkit()
    {
        const int itemId = 1;
        var mockHtmlService = GetMockDocument(new Toolkit(), itemId);
        var wikiItemService = new WikiItemService(mockHtmlService);

        var result = wikiItemService.Get(itemId);
        
        Assert.Equivalent(itemId, result.Id);
        Assert.Equivalent("Toolkit", result.Name);
        Assert.Equivalent(new DateTime(2003, 5, 27), result.ReleaseDate);
        Assert.True(result.IsMembers);
        Assert.False(result.IsTradeable);
        Assert.False(result.IsEquipable);
        Assert.False(result.IsStackable);
        Assert.Equivalent(@"I got this from Captain Lawgof.", result.DestroyText);
        Assert.Equivalent(@"Good for repairing broken cannons.", result.ExamineText);
        Assert.Equivalent(1, result.Value);
        Assert.Equivalent(0, result.HighAlchValue);
        Assert.Equivalent(0, result.LowAlchValue);
        Assert.Equivalent(0.453, result.Weight);
    }

    [Fact]
    [Trait("Category","Unit")]
    public void Get_Cannonball()
    {
        const int itemId = 2;
        var mockHtmlService = GetMockDocument(new Cannonball(), itemId);
        var wikiItemService = new WikiItemService(mockHtmlService);

        var result = wikiItemService.Get(itemId);
        
        Assert.Equivalent(itemId, result.Id);
        Assert.Equivalent("Cannonball", result.Name);
        Assert.Equivalent(new DateTime(2003, 5, 27), result.ReleaseDate);
        Assert.True(result.IsMembers);
        Assert.True(result.IsTradeable);
        Assert.False(result.IsEquipable);
        Assert.True(result.IsStackable);
        Assert.Equivalent(@"Drop", result.DestroyText);
        Assert.Equivalent(@"Ammo for the Dwarf Cannon.", result.ExamineText);
        Assert.Equivalent(5, result.Value);
        Assert.Equivalent(3, result.HighAlchValue);
        Assert.Equivalent(2, result.LowAlchValue);
        Assert.Equivalent((double)0, result.Weight);
    }

    [Fact]
    [Trait("Category","Unit")]
    public void Get_CannonBase()
    {
        const int itemId = 6;
        var mockHtmlService = GetMockDocument(new CannonBase(), itemId);
        var wikiItemService = new WikiItemService(mockHtmlService);

        var result = wikiItemService.Get(itemId);
        
        Assert.Equivalent(itemId, result.Id);
        Assert.Equivalent("Cannon base", result.Name);
        Assert.Equivalent(new DateTime(2003, 5, 27), result.ReleaseDate);
        Assert.True(result.IsMembers);
        Assert.True(result.IsTradeable);
        Assert.False(result.IsEquipable);
        Assert.False(result.IsStackable);
        Assert.Equivalent(@"Drop", result.DestroyText);
        Assert.Equivalent(@"The cannon is built on this.", result.ExamineText);
        Assert.Equivalent(187500, result.Value);
        Assert.Equivalent(112500, result.HighAlchValue);
        Assert.Equivalent(75000, result.LowAlchValue);
        Assert.Equivalent((double)10, result.Weight);
    }

    [Fact]
    [Trait("Category","Unit")]
    public void Get_LitCandleUnobtainable()
    {
        const int itemId = 6;
        var mockHtmlService = GetMockDocument(new LitCandleUnobtainable(), itemId);
        var wikiItemService = new WikiItemService(mockHtmlService);

        var result = wikiItemService.Get(itemId);
        
        Assert.Equivalent(itemId, result.Id);
        Assert.Equivalent("Lit candle", result.Name);
        Assert.Equivalent(new DateTime(2004, 3, 29), result.ReleaseDate);
        Assert.False(result.IsMembers);
        Assert.False(result.IsTradeable);
        Assert.False(result.IsEquipable);
        Assert.True(result.IsStackable);
        Assert.Equivalent(@"Drop", result.DestroyText);
        Assert.Equivalent(@"A lit candle.", result.ExamineText);
        Assert.Equivalent(0, result.Value);
        Assert.Equivalent(0, result.HighAlchValue);
        Assert.Equivalent(0, result.LowAlchValue);
        Assert.Equivalent(null, result.Weight);
    }

    [Fact]
    [Trait("Category","Unit")]
    public void Get_LitTorchUnobtainable()
    {
        const int itemId = 595;
        var mockHtmlService = GetMockDocument(new LitTorchUnobtainable(), itemId);
        var wikiItemService = new WikiItemService(mockHtmlService);

        var result = wikiItemService.Get(itemId);
        
        Assert.Equivalent(itemId, result.Id);
        Assert.Equivalent("Torch", result.Name);
        Assert.Equivalent(new DateTime(2004, 3, 29), result.ReleaseDate);
        Assert.False(result.IsMembers);
        Assert.False(result.IsTradeable);
        Assert.False(result.IsEquipable);
        Assert.True(result.IsStackable);
        Assert.Equivalent(@"Drop", result.DestroyText);
        Assert.Equivalent(@"A lit home-made torch.", result.ExamineText);
        Assert.Equivalent(0, result.Value);
        Assert.Equivalent(0, result.HighAlchValue);
        Assert.Equivalent(0, result.LowAlchValue);
        Assert.Equivalent(null, result.Weight);
    }

    [Fact]
    [Trait("Category","Unit")]
    public void Get_GroundCharcoal()
    {
        const int itemId = 704;
        var mockHtmlService = GetMockDocument(new GroundCharcoal(), itemId);
        var wikiItemService = new WikiItemService(mockHtmlService);

        var result = wikiItemService.Get(itemId);
        
        Assert.Equivalent(itemId, result.Id);
        Assert.Equivalent("Ground charcoal", result.Name);
        Assert.Equivalent(new DateTime(2003, 7, 9), result.ReleaseDate);
        Assert.True(result.IsMembers);
        Assert.False(result.IsTradeable);
        Assert.False(result.IsEquipable);
        Assert.False(result.IsStackable);
        Assert.Equivalent(@"Drop", result.DestroyText);
        Assert.Equivalent(@"Charcoal - crushed to small pieces!", result.ExamineText);
        Assert.Equivalent(1, result.Value);
        Assert.Equivalent(0, result.HighAlchValue);
        Assert.Equivalent(0, result.LowAlchValue);
        Assert.Equivalent(0.008, result.Weight);
    }

    /// <summary>
    /// Only use for finding what items break the application. Uncaught exceptions will help
    /// to find specific test cases to add above.
    /// </summary>
    /// <param name="htmlClass"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Fact]
    [Trait("Category","NoCI")]
    public void TestAllItems()
    {
        int min = 713;
        int max = 1000;
        var htmlService = new WikiHtmlService();
        var itemService = new WikiItemService(htmlService);
        
        for (int i = min; i < max; i++)
        {
            var item = itemService.Get(i);
            _testOutputHelper.WriteLine($"Id: {i} - {Newtonsoft.Json.JsonConvert.SerializeObject(item)}");
            
            Thread.Sleep(3000);
        }
    }

    private IHtmlService GetMockDocument(ITestHtml htmlClass, int id)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(htmlClass.Html);

        var mock = new Mock<IHtmlService>();
        mock.Setup(m => m.GetItemDocument(id)).Returns(doc.DocumentNode);

        return mock.Object;
    }
}