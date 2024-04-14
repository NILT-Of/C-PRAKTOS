using System;

class pr_6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите 9 чисел: ");
        int[,] masive = new int[3, 3]; //Создаем двумерный массив
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                masive[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Матрица: "); //Выводим его (с помощью интерполяции строк $)
            Console.WriteLine($"{masive[0, 0]} {masive[0, 1]} {masive[0, 2]}\n{masive[1, 0]} {masive[1, 1]} {masive[1, 2]}\n{masive[2, 0]} {masive[2, 1]} {masive[2, 2]}");
            //Выводим максимальные числа
            Console.WriteLine("Максимальное число в первой строке: {0}", Math.Max(masive[0, 0], Math.Max(masive[0, 1], masive[0, 2]))); 
            Console.WriteLine("Максимальное число во второй строке: {0}", Math.Max(masive[1, 0], Math.Max(masive[1, 1], masive[1, 2])));
            Console.WriteLine("Максимальное число в третей строке: {0}", Math.Max(masive[2, 0], Math.Max(masive[2, 1], masive[2, 2])));
            Console.WriteLine("Максимальное число в первом столбце: {0}", Math.Max(masive[0, 0], Math.Max(masive[1, 0], masive[2, 0])));
            Console.WriteLine("Максимальное число во втором столбце: {0}", Math.Max(masive[0, 1], Math.Max(masive[1, 1], masive[2, 1]))); 
            Console.WriteLine("Максимальное число в третьем столбце: {0}", Math.Max(masive[0, 2], Math.Max(masive[1, 2], masive[2, 2])));
        }
    }
}