using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some numbers separated by commas...");
            var userInput = Console.ReadLine().Split(",");
            int finalValue;
            string numberList = "";

            for (int i = 0; i < userInput.Length; i++)
            {
                finalValue = int.Parse(userInput[i]);
                finalValue *= finalValue;
                numberList += $"{finalValue}, ";
            }

            Console.WriteLine(numberList.Remove(numberList.Length - 2, 2));

            Console.ReadKey();
        }
    }
}