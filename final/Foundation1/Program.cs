using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        List<Video> videoList = new List<Video>();
        


        while (choice != 6)
        {
            Console.WriteLine("\nWelcome to Video Catalog. \n1.Enter video \n2.Enter comments \n3.Display a list of videos \n4.Display a list of videos and # of comments per video \n5.Display all \n6.Quit \n\nEnter an option:");

            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            switch (choice) 
            {
                case 1:
                    Console.WriteLine("You chose Option 1, to Enter a video.");
                    Video video = new Video();
                    video.addVideo();                    
                    videoList.Add(video);
                    break;
                case 2:
                    Console.WriteLine("You selected Option 2, to Enter comments.");
                    for (int i = 0; i < videoList.Count; i++)
                    {
                        videoList[i].display_videoList(i);
                    }
                    Console.WriteLine("Which video number do you want to add the comment to: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    number--;
                    videoList[number].addComment();

                    break;
                case 3:
                    Console.WriteLine("You selected Option 3, to display a list of videos.");
                    for(int i =0; i< videoList.Count; i++)
                    {
                        videoList[i].display_videoList(i);
                    }
                    
                    break;
                case 4:
                    Console.WriteLine("You selected Option 4, to display a list of videos and # of comments per video.");
                    foreach (Video vid in videoList)
                    {
                        vid.display_count();
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("You selected Option 5, to display all.");

                    foreach (Video vid in videoList)
                    {
                        vid.display_all();
                    }
                    break;
                case 6:
                    Console.WriteLine("Exiting the program...");
                    
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

        }
    }

}
