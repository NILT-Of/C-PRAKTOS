using System;

class pr_14
{
    static double RootK(double X, int K, int N)
    {
        if (N == 0)
        {
            return 1; //Y0 = 1
        }
        else
        {
            double YPrev = RootK(X, K, N - 1);
            return YPrev - (YPrev - X / Math.Pow(YPrev, K - 1)) / K;
        }
    }

    static void Main(string[] args)
    {
        double X = 16; // пример числа
        int K = 2; // пример степени
        int[] N_values = { 1, 2, 3, 4, 5, 6 }; // пример значений

        foreach (int N in N_values)
        {
            double root = RootK(X, K, N);
            Console.WriteLine($"При N = {N}, приближенное значение корня {K}-й степени из числа {X}: {root}");
        }
    }
}
