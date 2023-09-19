using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);

        
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNum = Console.ReadLine();
        int convertUserNum = int.Parse(userNum);
        return convertUserNum;
    }

    static int SquareNumber(int number)
    {
        int sqrRoot = number * number;
        return sqrRoot;             
    }

    static void DisplayResult(string userName, int sqrRoot)
    {
        Console.Write($"{userName}, the square of your number is {sqrRoot}");
    }


        

    
}