using System;

namespace AprendendoCsharp

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to the Lucky Dice Game! ===");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Start");
            Console.WriteLine("2 - Exit");
            Console.WriteLine();

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Great! Let's get started!");
                PlayDiceGame();
            }
            else if (choice == "2")
            {
                Console.WriteLine("See you next time!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }

        static void PlayDiceGame()
        {
            Random dice = new Random();
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
            Console.WriteLine();

            if ((roll1 == roll2 || roll2 == roll3 || roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!!! +999999999 bonus to total!!!");
                    total += 999999999;
                }
                else
                {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    total += 2;
                }
            }

            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Sorry, you lose.");
            }
        }
    }
}


