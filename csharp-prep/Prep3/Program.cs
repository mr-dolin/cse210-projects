using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRun = true;

        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 20);

        int numberOfGuess = 1;

        while (isRun)
        {
            Console.Write("What is your guess? ");
            string numGuess = Console.ReadLine();

            int convertNumGuess = int.Parse(numGuess);

            

            if (convertNumGuess > magicNum)
            {
                Console.WriteLine("Lower");
                numberOfGuess += 1;
            }
            else if (convertNumGuess < magicNum)
            {
                Console.WriteLine("Higher");
                numberOfGuess += 1;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.Write($"It took you {numberOfGuess} times to guess");
                Console.WriteLine("Would you like to play again? ");
                string playAgain = Console.ReadLine();

                if (playAgain == "yes")
                {
                    magicNum = randomGenerator.Next(1, 20);
                    numberOfGuess = 1;
                    isRun = true;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    isRun = false;
                }

                
            }
        }


        

    }
}