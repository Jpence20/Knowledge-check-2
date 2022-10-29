using System;
public class Program
{
    
    public static void Main(string[] args)
    {


        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<VideoGames>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            Console.WriteLine("Enter the value for name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the value for genre");
            string genre = Console.ReadLine();

            Console.WriteLine("Enter the value for publisher ");
            string publisher = Console.ReadLine();

            Console.WriteLine("Enter the value for console Exclusive ");
            string consoleExclusive = Console.ReadLine();



            var videogames = new VideoGames(name, genre, publisher, consoleExclusive);




            recordList.Add(videogames);


        }
        foreach (var entry in recordList)
            Console.WriteLine($"Game:{entry.name} Genre:{entry.genre} Publisher:{entry.publisher} consoleExcuslive{entry.consoleExclusive}");
    }
}