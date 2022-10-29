

 static void Main(string[] args)
{


    Console.WriteLine("How many records do you want to add? ");
    var numberOfRecords = int.Parse(Console.ReadLine());

    var recordList = new List<VideoGames>();
    for (int i = 0; i < numberOfRecords; i++)
    {
        // In this loop, populate the object's properties using Console.ReadLine()
        var videogames = new VideoGames();

        Console.WriteLine("Enter the value for ");
        string name = Console.ReadLine();


        recordList.Add(videogames);
    }
}