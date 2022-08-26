using Algorithms_Data_structures;

namespace Algorithms_Data_structures;


internal class Task3
{
    // Задание 3. Число Фибонначи. Реализовать рекурсивную версию и версию без рекурсии (через цикл)
    // Fn = Fn-1 + Fn-2, n<2


    /// <summary>
    /// Вычисление числа Фибонначи рекурсивным способом.
    /// </summary>
    /// <param name="value">Входное значение</param>
    /// <returns>число Фибонначи</returns>
    /// 
    static int FibRec(int value)
    {
        try
        {
            NumIsValid(value);

            if (value < 2)
            {
                return value;
            }
            else
            {

                return FibRec(value - 1) + FibRec(value - 2);
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
            return value;
        }

    }

    /// <summary>
    /// Число Фибонначи через цикл.
    /// Fn = Fn-1 + Fn-2, n<2
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    static int Fib(int num)
    {

        try
        {
            NumIsValid(num);

            int result = 0;
            int b = 1;
            int temp;

            for (int i = 0; i < num; i++)
            {
                temp = result;
                result = b;
                b += temp;
            }

            return result;
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
            return num;
        }
    }


    /// <summary>
    /// Проверка числа на валидность
    /// </summary>
    /// <param name="value">проверямое число</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    static int NumIsValid(int value)
    {
        if (value < 0)
        {
            throw new ArgumentException($"Ошибка! Число должно быть 0, либо натуральным!");
        }
        return value;
    }

    public void Test()
    {
        Console.WriteLine("Lesson 1, Task 3");

        //Проверка функции с рекурсией
        Console.WriteLine($"Входное значение 0 => {FibRec(0)}");
        Console.WriteLine($"Входное значение 1 => {FibRec(1)}");
        Console.WriteLine($"Входное значение 12 => {FibRec(12)}");
        Console.WriteLine($"Входное значение -1 => {FibRec(-1)}");
        Console.WriteLine($"Входное значение -20 => {FibRec(-20)}");

        Console.WriteLine("*************************************");

        //Проверка функции с циклом
        Console.WriteLine($"Входное значение 0 => {Fib(0)}");
        Console.WriteLine($"Входное значение 1 => {Fib(1)}");
        Console.WriteLine($"Входное значение 12 => {Fib(12)}");
        Console.WriteLine($"Входное значение -1 => {Fib(-1)}");
        Console.WriteLine($"Входное значение -20 => {Fib(-20)}");
    }
}

