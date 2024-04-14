using System;

class pr_5
{
    static void Main(string[] args)
    {
        // Вводим размер массива
        Console.Write("Введите размер массива (N): ");
        int N = int.Parse(Console.ReadLine());

        // Создание массива и ввод чисел
        int[] numbers = new int[N];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < N; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Вывод элементов в обратном порядке
        Console.WriteLine("Массив в обратном порядке:");
        for (int i = N - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}