using System;
using VideoGames;


internal class Program
{



    public static void Main(string[] args)
    {

        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var myClass = new MyClass();

            Console.WriteLine("Enter the value for ");
            myClass. = Console.ReadLine();


            recordList.Add(myClass);
        }
    }
}

