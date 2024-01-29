using System;

namespace TextGame
{
    class RiddleRoom
    {
        private static bool riddleAsked = false;

        public static void Entry(int numberOfChances)
        {
            if (!riddleAsked)
            {
                int remainingChances = numberOfChances;

                while (remainingChances > 0)
                {
                    Console.WriteLine($"NPC: Hello! I will ask you a riddle. If you know the correct answer, you win the game.");
                    Console.WriteLine("Riddle: People pay for it, but they cut its own tail before using it. What is it?");
                    Console.WriteLine("A) Book");
                    Console.WriteLine("B) Pen");
                    Console.WriteLine("C) Clock");
                    Console.WriteLine("D) Scissors");
                    Console.WriteLine("E) Money");

                    string correctAnswer = "C";

                    Console.Write("Enter your answer (A, B, C, D, or E): ");
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Congratulations! Correct answer. You won the game!");
                        riddleAsked = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, wrong answer. Try again.");
                        remainingChances--;
                        Console.WriteLine($"Remaining chances: {remainingChances}");
                    }
                }

                if (remainingChances == 0)
                {
                    Console.WriteLine("Sorry, you used all your chances. You lost the game.");
                }

                Console.Write("Press any key...");
                Console.ReadKey();
                Console.Clear(); 

                Room.Entry();
            }
            else
            {
                Console.WriteLine("I already asked a riddle here. You should go to another room.");

                Console.Write("Press any key...");
                Console.ReadKey();
                Console.Clear(); 

                Room.Entry();
            }
        }
    }
}
