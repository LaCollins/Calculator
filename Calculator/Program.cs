using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some numbers separated by commas...");
            var userInput = Console.ReadLine().Split(",");
            int finalSquareValue;
            var finalMultipliedValue = 0;
            string numberList = "";

            for (int i = 0; i < userInput.Length; i++)
            {
                finalSquareValue = int.Parse(userInput[i]);
                finalSquareValue *= finalSquareValue;
                numberList += $"{finalSquareValue}, ";
            }

            int firstNum = int.Parse(userInput[0]);

            for (int i = 1; i < userInput.Length; i++)
            {
                int secondNum = int.Parse(userInput[i]);
                finalMultipliedValue = firstNum * secondNum;
                firstNum = finalMultipliedValue;
            }

            Console.WriteLine(finalMultipliedValue);

            Console.WriteLine($"Squared {numberList.Remove(numberList.Length - 2, 2)}");

            Console.ReadKey();
        }
    }
}