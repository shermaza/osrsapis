using HtmlAgilityPack;

namespace DpsCalculator.WikiService;

public class WikiHtmlService : IHtmlService
{
    private string _baseUrl = "https://oldschool.runescape.wiki/w/Special:Lookup?type=item&id=";

    public HtmlNode GetItemDocument(int id)
    {
        var web = new HtmlWeb();
        var doc = web.Load(_baseUrl + id.ToString());
        var document = doc.DocumentNode;

        return document;
    }
}