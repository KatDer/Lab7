using System;

class Program
{
    static void Main()
    {
        double n,r;
        Console.Write("Введите сторону n-угольника : "); //информируем пользователя о требуемом действии
        n = Convert.ToDouble(Console.ReadLine()); // считывание строки из консоли
        Console.Write("Введите радиус описанной окружности : "); //информируем пользователя о требуемом действии
        r = Convert.ToDouble(Console.ReadLine()); // считывание строки из консоли
        Console.WriteLine("Периметр равен: " + (2 * n * r * (Math.Sin ((Math.PI / n))))); //вывод результата вычислений
    }
}