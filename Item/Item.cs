namespace DpsCalculator.Item;

// https://oldschool.runescape.wiki/w/Special:Lookup?type=item&id=12011

public class Item
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? DestroyText { get; set; }
    public string? ExamineText { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public bool IsStackable { get; set; }
    public bool IsMembers { get; set; }
    public bool IsTradeable { get; set; }
    public bool IsEquipable { get; set; }
    public int Value { get; set; }
    public int HighAlchValue { get; set; }
    public int LowAlchValue { get; set; }
    public double? Weight { get; set; }
}