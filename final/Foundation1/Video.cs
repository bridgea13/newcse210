using System;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

public class Video
{


    public string title;
    public string author;
    public int length;
    string videoList;
    List<Comment> commentList = new List<Comment>();
    
    public void addVideo()
    {
        Console.WriteLine("Enter video title: ");
        title = Console.ReadLine();
        Console.WriteLine("Enter video author: ");
        author = Console.ReadLine();
        Console.WriteLine("Enter video length in seconds: ");
        length = int.Parse(Console.ReadLine());

    }




     public void display_videoList(int number)
     {

        Console.Clear();
        number++;
        Console.WriteLine("Video Number: " + Convert.ToString(number));
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Length: " + Convert.ToString(length) + " seconds");
    }

    public void addComment()
    {
        Console.Clear();
        Console.WriteLine("Enter comment creator's name: ");
        string commentor = Console.ReadLine();
        Console.WriteLine("Enter text of comment: ");
        string text = Console.ReadLine();
        Comment comment = new Comment(text, commentor);
        commentList.Add(comment);
    }
    internal void display_all()
    {
        
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Length: " + Convert.ToString(length) + " seconds");
        foreach (Comment com in commentList)
        {
            com.display_comment();
        }
    }

    internal void display_count()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Length: " + Convert.ToString(length) + " seconds");
        int comCount = commentList.Count;
        Console.WriteLine("Comment count: " + comCount);
    }
}

