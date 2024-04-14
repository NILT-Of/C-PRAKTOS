using System;

class pr_13
{
    static void Main()
    {
        Console.Write("Введите число: ");
        double number = double.Parse(Console.ReadLine());
        double result = PowerA3(number);
        Console.WriteLine($"Третья степень числа {number} равна {result}");
    }

    static double PowerA3(double A)
    {
        return Math.Pow(A, 3);
    }
}
