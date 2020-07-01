using System;

namespace NumGuess
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Hello Player!");

            Random r = new Random();

            int guessInt = 0;

            int target = r.Next(1, 200);

            Console.WriteLine(Convert.ToString(target));




            do
            {
                Console.WriteLine("Guess a number between 1 and 200: ");
                string guess = Console.ReadLine();
                guessInt = Convert.ToInt32(guess);

                if (guessInt < target)
                {
                    Console.WriteLine("Too Low, try again");


                }
                else if (guessInt > target)
                {
                    Console.WriteLine("Too High, try again");

                }

            } while (guessInt != target);

            Console.WriteLine("Congrats! Correct!");
        }
    }
}
