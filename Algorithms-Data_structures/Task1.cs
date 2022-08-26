namespace Algorithms_Data_structures;

internal class Task1
{
    /// <summary>
    /// Задание 1. Реализация функции, которая выполняет проверку: число простое или нет (составное)?
    /// </summary>


    /// <summary>
    /// Метод проверки, натуральное ли число?
    /// </summary>
    /// <param name="num">число, которое подается на вход</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    static int NumIsNatural(int num)
    {
        if (num <= 0)
        {
            throw new ArgumentException($"{num} => Число должно быть натуральным ( > 0 )!");
        }
        return num;
    }

    /// <summary>
    /// Реализация алгоритма проверки числа: простое или нет?
    /// </summary>
    /// <param name="num">проверяемое число</param>
    static void SimpleNum(int num)
    {
        int d = 0, i = 2;
        try
        {
            NumIsNatural(num);
            {
                while (i < num)
                {
                    if (num % i == 0)
                    {
                        d++;
                    }

                    i++;
                }
                if (d == 0)
                {
                    Console.WriteLine($"{num} => Число простое");
                }
                else
                {
                    Console.WriteLine($"{num} => Число составное (!простое)");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void TestFunc()
    {
        Console.WriteLine ("Lesson 1, Task 1");

        SimpleNum(2); // проверки с простыми числами
        SimpleNum(97);
        SimpleNum(67);

        SimpleNum(45); //проверки с составными числами
        SimpleNum(15);

        SimpleNum(-1); //проверка с невалидным числом
    }
}
