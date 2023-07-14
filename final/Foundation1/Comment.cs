using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Comment
{
    public string Commentor { get; set; }
    public string Text { get; set; }
    


    public Comment(string commentor, string text)
    {
        Commentor = commentor;
        Text = text;

    }

    internal void display_comment()
    {
        Console.WriteLine("Comment Creator's Name: " + Commentor);
        Console.WriteLine("Comment: " + Text);
    }
}
