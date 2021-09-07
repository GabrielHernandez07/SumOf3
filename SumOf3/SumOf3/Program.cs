using System;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber, thirdNumber;
            const double constantNumber = 7.777;

            Console.WriteLine("Type a number. >>");
            string answer = Console.ReadLine();
            firstNumber = Convert.ToDouble(answer);

            Console.WriteLine("Type a different number. >>");
            string number = Console.ReadLine();
            secondNumber = Convert.ToDouble(number);

            Console.WriteLine("Type a differnt number. >>");
            string letter = Console.ReadLine();
            thirdNumber = Convert.ToDouble(letter);

            Console.WriteLine("Sum of Three Numbers");
            double sumNumber = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine(sumNumber.ToString("N3"));

            Console.WriteLine("Final Answer");
            double secondValue = constantNumber * sumNumber;
            Console.WriteLine(secondValue.ToString("N3"));
        }
    }
}
