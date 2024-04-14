using System;
using System.IO;
using System.Linq;

class pr_4

{
    static void Main()
    {
        int sotchik = 0;
        int cyma = 0;
        Console.WriteLine("Введите количество чисел в массиве: ");
        int O = Convert.ToInt32(Console.ReadLine());
        int[] maseve = new int[O];
        Console.WriteLine("Введите {0} чисел: ", O);
        for (int i = 0; i < O; i++)
        {
            maseve[i] = Convert.ToInt32(Console.ReadLine());
        }
        foreach (var chislo in maseve)
        {
            if (chislo % 2 != 0)
            {
                ++sotchik;
                cyma += chislo;
            }
        }
        if (sotchik == 0)
        {
            Console.WriteLine("Нет нечётных чисел (");
        }
        else
        {
            Console.WriteLine("Среднее арифметическое нечётных чисел: \n{0}", (float)cyma / sotchik);
        }
    }
}