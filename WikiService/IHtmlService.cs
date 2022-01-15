using HtmlAgilityPack;

namespace DpsCalculator.WikiService;

public interface IHtmlService
{
    public HtmlNode GetItemDocument(int id);
}