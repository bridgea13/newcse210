using System;

public class Scripture
{
    public Reference Citation;
    public string Text { get; set; }

    List<Word> Words = new List<Word>();


    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        Citation = new Reference(book, chapter, startVerse, endVerse);
        Text = text;
        createList();
    }



    public Scripture(string book, int chapter, int startVerse, string text)
    {
        Citation = new Reference(book, chapter, startVerse);
        Text = text;
        createList();
    }

    private void createList()
    {
        char[] separators = { ' ', ',', '.' };
        string[] words = Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            Word word1 = new Word(word);
            Words.Add(word1);
        }

    }
    public void DisplayScripture()
    {
        Citation.DisplayReference();
        Console.WriteLine(Text);
    }

    public void HideWords()
    {
        int hiddenWords = 0;
        int allWordsHidden = 0;
        string result = "";
        while (hiddenWords < 5)
        {
            allWordsHidden = 0;
            Random random = new Random();
            int randomWord = random.Next(Words.Count);
            if (Words[randomWord].Hidden == false)
            {
                Words[randomWord].Hidden = true;
                hiddenWords++;
                
            }
            
            foreach (Word word in Words)
            {
                if (word.Hidden== true) { allWordsHidden++; }
                
            }
            
            if (allWordsHidden ==Words.Count)
            {
                hiddenWords = 12;
            }
            

        }
        foreach (Word word in Words)
        {
            if (word.Hidden == false)
            {
                result += word.SingleWord;
            }
            else { result += "___"; }
            result += " ";
        }
        Console.WriteLine(result);

    }


}


