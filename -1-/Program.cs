using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число : "); //информируем пользователя о требуемом действии
        int n = int.Parse(Console.ReadLine()); // считывание строки из консоли
        Console.WriteLine("Число единиц: " + (n % 10)); //вывод результата вычислений
    }
}