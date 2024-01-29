using System;

namespace TextGame
{
    class LivingRoom
    {
        public static void Entry()
        {
            Console.WriteLine("Welcome to the living room! There is nothing here.");

            Console.Write("Press any key...");
            Console.ReadKey();
            Console.Clear(); 

            Room.Entry();
        }
    }
}
