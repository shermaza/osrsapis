using System.Globalization;
using System.Reflection.Metadata;
using HtmlAgilityPack;

namespace DpsCalculator.WikiService.ItemService;

public class WikiItemService : IItemService
{
    private readonly IHtmlService _htmlService;

    public WikiItemService(IHtmlService htmlService)
    {
        _htmlService = htmlService;
    }

    public Item.Item? Get(int id)
    {
        var document = _htmlService.GetItemDocument(id);

        if (document.SelectSingleNode("//*[@id=\"Welcome_to_the_OSRS_Wiki!\"]") != null)
        {
            return null;
        }
        
        var item = new Item.Item
        {
            Id = id,
            Name = GetName(document),
            DestroyText = GetDestroyText(document),
            ExamineText = GetExamineText(document),
            ReleaseDate = GetReleaseDate(document),
            IsStackable = GetIsStackable(document),
            IsMembers = GetIsMembers(document),
            IsTradeable = GetIsTradeable(document),
            IsEquipable = GetIsEquipable(document),
            Value = GetValue(document),
            HighAlchValue = GetHighAlchValue(document),
            LowAlchValue = GetLowAlchValue(document),
            Weight = GetWeight(document)
        };

        return item;
    }

    public Item.Item? Get(CacheItem.CacheItem cacheItem)
    {
        return Get(cacheItem.Id);
    }

    private string GetName(HtmlNode document)
    {
        var nameNode = document.SelectSingleNode("//*[@id='mw-content-text']//table[contains(@class, 'rsw-infobox')]/tbody/tr[1]/th");
        var text = nameNode.GetDirectInnerText();

        return text;
    }

    private string GetDestroyText(HtmlNode document)
    {
        var textValue = GetInfoboxValueByLabel("Destroy", document);
        return textValue;
    }

    private string GetExamineText(HtmlNode document)
    {
        var textValue = GetInfoboxValueByLabel("Examine", document);
        return textValue;
    }

    private DateTime GetReleaseDate(HtmlNode document)
    {

        const string xpath = "//*[@id=\"mw-content-text\"]//*[text()='Released']/../td";
        var node = document.SelectSingleNode(xpath);
        var text = node.InnerText;
        
        var year = int.Parse(node.InnerText.Split()[2]);
        var month = DateTime.ParseExact(node.InnerText.Split()[1], "MMMM", CultureInfo.CurrentCulture ).Month;
        var day = int.Parse(node.InnerText.Split()[0]);

        var releaseDate = new DateTime(year, month, day);
        return releaseDate;
    }

    private bool GetIsStackable(HtmlNode document)
    {
        var textValue = GetInfoboxValueByLabel("Stackable", document);
        return textValue == "Yes";
    }
    
    private bool GetIsMembers(HtmlNode document)
    {
        var textValue = GetInfoboxValueByLabel("Members", document);
        return textValue == "Yes";
    }
    
    private bool GetIsTradeable(HtmlNode document)
    {
        var textValue = GetInfoboxValueByLabel("Tradeable", document);
        return textValue == "Yes";
    }
    
    private bool GetIsEquipable(HtmlNode document)
    {
        var textValue = GetInfoboxValueByLabel("Equipable", document);
        return textValue == "Yes";
    }
    
    private int GetValue(HtmlNode document)
    {
        var textValue = GetInfoboxValueByLabel("Value", document);

        return int.Parse(textValue.Split()[0].Replace(",", string.Empty));
    }
    
    /// <summary>
    /// Returns the high alchemy value from the Wiki infobox. If the item is not allowed to be
    /// alchemised, or if the infobox does not specify an alchemy value, 0 is assumed.
    /// </summary>
    /// <param name="document"></param>
    /// <returns></returns>
    private int GetHighAlchValue(HtmlNode document)
    {
        string textValue;

        /* The HTML can show either "Alchemy" or "Low alch" depending on whether or not the item can be alched */
        try
        {
            textValue = GetInfoboxValueByLabel("Alchemy", document);
        }
        catch (NullReferenceException e)
        {
            textValue = GetInfoboxValueByLabel("High alch", document);
        }

        return textValue == "Not alchemisable" ? 0 : int.Parse(textValue.Split()[0].Replace(",", string.Empty));
    }
    
    private int GetLowAlchValue(HtmlNode document)
    {
        string textValue;

        /* The HTML can show either "Alchemy" or "Low alch" depending on whether or not the item can be alched */
        try
        {
            textValue = GetInfoboxValueByLabel("Alchemy", document);
        }
        catch (NullReferenceException e)
        {
            textValue = GetInfoboxValueByLabel("Low alch", document);
        }

        return textValue == "Not alchemisable" ? 0 : int.Parse(textValue.Split()[0].Replace(",", string.Empty));
    }
    
    private double? GetWeight(HtmlNode document)
    {
        var textValue  = GetInfoboxValueByLabel("Weight", document);
        
        /* Some items have an Unknown weight, so we will consider that Null */
        if (textValue.Split()[0] == "Unknown" || textValue.Split()[0] == "?")
        {
            return null;
        }
        
        return double.Parse(textValue.Split()[0]);
    }

    /// <summary>
    /// Gets the text of the infobox row by the label, i.e. the label "Tradeable" will be "Yes" or "No"
    /// </summary>
    /// <param name="label"></param>
    /// <param name="document"></param>
    /// <returns></returns>
    private string GetInfoboxValueByLabel(string label, HtmlNode document)
    {
        var xpath = String.Format("//*[@id=\"mw-content-text\"]//*[text()='{0}']/../../td", label);
        var node = document.SelectSingleNode(xpath);

        return node.InnerText;
    }
    
}