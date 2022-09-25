﻿class Program
{
    //Для прямоугольного поля размера M на N клеток, подсчитать количество путей из верхней левой
    //клетки в правую нижнюю. Известно что ходить можно только на одну клетку вправо или вниз.

    const int N = 10;
    const int M = 10;
    static void Print2(int n, int m, int[,] a)
    {
        int i, j;
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
                Console.Write(a[i, j] + "  ");
            Console.Write("\r\n");
        }
    }
    static void Main(string[] args)
    {
        int[,] A = new int[N, M];
        int i, j;
        for (j = 0; j < M; j++)
            A[0, j] = 1; // Первая строка заполнена единицами
        for (i = 1; i < N; i++)
        {
            A[i, 0] = 1;
            for (j = 1; j < M; j++)
                A[i, j] = A[i, j - 1] + A[i - 1, j];
        }
        Print2(N, M, A);

        Console.WriteLine("Завершение работы программы...");
        Console.ReadLine();
    }
}



