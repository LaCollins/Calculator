using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter math method followed by a space and some numbers separated by commas...");
            var userInput = Console.ReadLine().Split(" ");
            var method = userInput[0];
            var numbers = userInput[1].Split(",");

            switch (method)
            {
                case "*":
                    var finalMultipliedValue = 0;
                    var firstNum = int.Parse(numbers[0]);

                    for (int i = 1; i < numbers.Length; i++)
                    {
                        int secondNum = int.Parse(numbers[i]);
                        finalMultipliedValue = firstNum * secondNum;
                        firstNum = finalMultipliedValue;
                    }
                    Console.WriteLine(finalMultipliedValue);
                    break;
                case "^2":
                    int finalSquareValue;
                    var numberList = "";

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        finalSquareValue = int.Parse(numbers[i]);
                        finalSquareValue *= finalSquareValue;
                        numberList += $"{finalSquareValue}, ";
                    }
                    Console.WriteLine(numberList.Remove(numberList.Length - 2, 2));
                    break;
                case "+":
                    var finalAddValue = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        finalAddValue += int.Parse(numbers[i]);
                    }
                    Console.WriteLine(finalAddValue);
                    break;
                case "/":
                    var finalDivisionValue = int.Parse(numbers[0]);

                    for (int i = 1; i < numbers.Length; i++)
                    {
                        finalDivisionValue /= int.Parse(numbers[i]);
                    }
                    Console.WriteLine(finalDivisionValue);
                    break;
                case "avg":
                    var addedValue = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        addedValue += int.Parse(numbers[i]);
                    }

                    Console.WriteLine(addedValue / numbers.Length);
                    break;

            }

            Console.ReadKey();
        }
    }
}