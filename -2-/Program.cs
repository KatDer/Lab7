using System;

class Program
{
    static void Main()
    {
        double a, b;
        Console.Write("Введите первый катет : "); //информируем пользователя о требуемом действии
        a = Convert.ToDouble(Console.ReadLine()); // считывание строки из консоли
        Console.Write("Введите первый катет : "); //информируем пользователя о требуемом действии
        b = Convert.ToDouble(Console.ReadLine()); // считывание строки из консоли
        Console.WriteLine("Гипотенуза равна: " + Math.Sqrt(a * a + b * b)); //вывод результата вычислений
    }
}