using System;
public class Program
{
    
    public static void Main(string[] args)
    {
       

        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<openWorld>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            var videogames = new openWorld();
            // In this loop, populate the object's properties using Console.ReadLine()
            Console.WriteLine("what is the name of your game?");
            videogames.name = Console.ReadLine();

            Console.WriteLine("What is the Genre?");
            videogames.genre = Console.ReadLine();

            Console.WriteLine("Who is the Publisher? ");
           videogames.publisher  = Console.ReadLine();

            Console.WriteLine("Is your game open world");
            string world = Console.ReadLine();
            if(world == "yes")
            {
                videogames.IsOpenWorld = true;
            }
            else
            {
                videogames.IsOpenWorld = false;
            }
   




            recordList.Add(new openWorld() { name = videogames.name, genre = videogames.genre, publisher = videogames.publisher, IsOpenWorld = videogames.IsOpenWorld });


        }
        foreach (var videoGames in recordList)
            Console.WriteLine($"Game: {videoGames.name}| Genre: {videoGames.genre}| Publisher: {videoGames.publisher}| OpenWorld: {videoGames.IsOpenWorld}");
    }
}