using System;

public class Scripture
{
    public Reference Citation;
    public string Text { get; set; }
    
    

    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        Citation = new Reference(book, chapter, startVerse, endVerse);
        Text = text;
       
    }
    public Scripture(string book, int chapter, int startVerse, string text)
    {
        Citation = new Reference(book, chapter, startVerse);
        Text = text;

    }
    public void DisplayScripture()
    {
        Citation.DisplayReference();
        Console.WriteLine(Text);
    }
}
