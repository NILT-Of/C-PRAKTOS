using System;

class pr_12
{
    static void DigitCountSum(int K, out int C, out int S)
    {
        C = 0;
        S = 0;

        string number = K.ToString();

        foreach (char digit in number)
        {
            S += int.Parse(digit.ToString());
        }
    }

    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
            Console.Clear();
        }
        foreach (int num in numbers)
        {
            int count, sum;
            DigitCountSum(num, out count, out sum);
            Console.WriteLine($"Для числа {num}: количество цифр = {count}, сумма цифр = {sum}");
        }
    }
}
