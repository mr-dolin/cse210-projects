using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

       Console.WriteLine("Enter a list of numbers, type 0 when finished");

       bool notZero = true;       

       while (notZero)
       {
        Console.Write("Enter a number: ");
        string enterNum = Console.ReadLine();
        int convertNum = int.Parse(enterNum);

        if (convertNum != 0)
        {
            numbers.Add(convertNum);
        }
        else
        {
            notZero = false;
        }
       } 

        int largeNum = 0;
        int smallPosNum = 10;

       int listLen = numbers.Count;
       


        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
            if (num > largeNum)
            {
                largeNum = num;
            }
            if (smallPosNum > num && num > 0)
            {
                smallPosNum = num;
            }
        }

        numbers.Sort();


        float avg = ((float)sum) / listLen;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largeNum}");
        Console.WriteLine($"The smallest positive number is: {smallPosNum}");
        Console.WriteLine("The sorted list is: ");
        for (int i = 0; i < listLen; i++)
        {
            int number = numbers[i];
            Console.WriteLine(number);
        }
    }
}