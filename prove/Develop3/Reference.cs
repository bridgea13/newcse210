using System;


public class Reference
{
    public string Book;
    public int Chapter;
    public int StartVerse;
    public int EndVerse;


    public Reference(string book, int chapter, int startVerse, int endVerse) 
    {
        
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;        

    }
    public Reference(string book, int chapter, int startVerse)
    {

        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        
        
    }

    public void DisplayReference()
    {
        Console.WriteLine(Book + " " + Chapter + ":" + StartVerse + " " + EndVerse);
    }
}

