using System;

namespace console_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nWhat is your name, dummy? ");
            string name = Console.ReadLine();

            Banner($"Greetings, {name}!!");

            Boolean correctKey = false;

            do {
                Console.WriteLine($"Now, do me a favor and press the [K] key would ya?");
                ConsoleKeyInfo key = Console.ReadKey();

                correctKey = key.Key == ConsoleKey.K;

                if (!correctKey) {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Uhm, I said the [K] key ya dingus...");
                    Console.WriteLine();
                }
            } while (!correctKey);

            Banner($"YAY YOU CAN READ!!!");
        }

        private static void Banner(string text) {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("************************************");
            Console.WriteLine($"\t{text}");
            Console.WriteLine("************************************");
            Console.WriteLine();
        }
    }
}
