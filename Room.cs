using System;

namespace TextGame

{     

  class Room

{

    private static bool mysteriousObjectCollected = false;

    public static void Entry()
    {
        Console.WriteLine("Welcome to the HOUSE! Where would you like to go?");
        Console.Write("Options: kitchen, living room, bedroom: ");
        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "kitchen":
                if (!mysteriousObjectCollected)
                {
                    Console.WriteLine("You must first find the mysterious object!");
                    Console.Write("Press any key...");
                    Console.ReadKey();
                    Console.Clear(); 
                    Entry();
                }
                else
                {
                    Console.WriteLine("Welcome to the kitchen!");
                    RiddleRoom.Entry(2); 
                }
                break;
            case "living room":
                LivingRoom.Entry();
                break;
            case "bedroom":
                if (!mysteriousObjectCollected)
                {
                    CollectMysteriousObject();
                    Entry();
                }
                else
                {
                    Console.WriteLine("You already found a mysterious object here!");
                    Console.Write("Press any key...");
                    Console.ReadKey();
                    Console.Clear(); 
                    Entry();
                }
                break;
            default:
                Console.WriteLine("Invalid option! Please try again.");
                Entry();
                break;
        }
    }

    private static void CollectMysteriousObject()
    {
        Console.WriteLine("You found and collected a mysterious object in this room!");
        mysteriousObjectCollected = true;

        Console.Write("Press any key...");
        Console.ReadKey();
        Console.Clear(); 
    }
}
}