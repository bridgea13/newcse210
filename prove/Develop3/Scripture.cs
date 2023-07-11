

public class Scripture
{
    public string Citation { get; set; }
    public string Text { get; set; }
    public Citation(string text, string citation)
    {
        Text = text;
        Citation = citation;
    }
}
