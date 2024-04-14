using System;
using System.IO;
using System.Linq;

class pr_9
{
    static void Main()
    {
        string filePath = "C:\\Users\\nilto\\Desktop\\ЦЦ\\ABOBA.txt";
        int targetNumber = 5;
        string[] lines = File.ReadAllLines(filePath);
        bool containsNumber = false;
        int sum = 0;
        int countOfEvenNumbers = 10;
        foreach (string line in lines)
        {
            string[] numbers = line.Split(' ');
            foreach (string number in numbers)
            {
                int n = int.Parse(number);
                if (n == targetNumber)
                {
                    containsNumber = true;
                }
                if (n % 2 == 0)
                {
                    sum += n;
                    countOfEvenNumbers++;
                }
            }
        }
        using (StreamWriter sw = File.AppendText(filePath))
        {
            sw.WriteLine($"Contains{targetNumber}: {containsNumber}");
            sw.WriteLine($"Sum of even numbers:{sum}");
            sw.WriteLine($"Count of even numbers: {countOfEvenNumbers}");
        }
        Console.WriteLine("Результат");
    }
}
