using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int convertUserInput = int.Parse(userInput);
        string letter = string.Empty;


        if (convertUserInput >= 93)
        {
            letter = "A";
            Console.WriteLine($"{letter}");
        }
        else if (convertUserInput >= 90 && convertUserInput < 93)
        {
            letter = "A-";
            Console.WriteLine($"{letter}");
        }
        else if (convertUserInput >= 87 && convertUserInput < 90)
        {
            letter = "B+";
            Console.WriteLine($"{letter}");
        }
        else if (convertUserInput >= 83 && convertUserInput < 87)
        {
            letter = "B";
            Console.WriteLine($"{letter}");
        }
        else if (convertUserInput >= 80 && convertUserInput < 83)
        {
            letter = "B-";
            Console.WriteLine($"{letter}");
        }
        else if (convertUserInput >= 77 && convertUserInput < 80)
        {
            letter = "C+";
            Console.WriteLine($"{letter}");
        }
        else if (convertUserInput >= 73 && convertUserInput < 77)
        {
            letter = "C";
            Console.WriteLine($"{letter}");
        }
        else if (convertUserInput >= 70 && convertUserInput < 73)
        {
            letter = "C-";
            Console.WriteLine($"{letter}");
        }
        else if (convertUserInput >= 67 && convertUserInput < 70)
        {
            letter = "D+";
            Console.WriteLine($"{letter}");
        }
        else if (convertUserInput >= 63 && convertUserInput < 67)
        {
            letter = "D";
            Console.WriteLine($"{letter}");
        }
        else if (convertUserInput >= 60 && convertUserInput < 63)
        {
            letter = "D-";
            Console.WriteLine($"{letter}");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"{letter}");
        }

        if (convertUserInput >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the class");
        }
        else
        {
            Console.WriteLine("Sorry, you have failed the class");
        }


    }
}