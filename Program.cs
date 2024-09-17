using System;
namespace fds;
class Program
{
    static void Main()
    {
        // Ввод пользователя
        Console.Write("Введите первый элемент (a1): ");
        double a1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите разность прогрессии (d): ");
        double d = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество элементов (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Вычисление и вывод элементов прогрессии
        Console.WriteLine("Элементы арифметической прогрессии:");

        for (int i = 0; i < n; i++)
        {
            double an = a1 + i * d; // Формула для нахождения n-го элемента
            Console.WriteLine($"a{i + 1} = {an}");
        }
    }
}
