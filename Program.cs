using System;

namespace Task1_ReverseNumber {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.Write("Введіть ціле число: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) break;

                int number = int.Parse(input);
                bool isNegative = number < 0;
                int tempNumber = Math.Abs(number);
                int reversedNumber = 0;

                while (tempNumber > 0) {
                    int lastDigit = tempNumber % 10;
                    reversedNumber = reversedNumber * 10 + lastDigit;
                    tempNumber /= 10;
                }

                if (isNegative) {
                    reversedNumber = -reversedNumber;
                }

                Console.WriteLine($"Результат: {reversedNumber}\n");
            }
        }
    }
}

