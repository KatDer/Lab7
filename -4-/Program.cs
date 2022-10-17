class Program
{
    static void Main(string[] args)
    {
        double x, y;//объявдение переменных
        Console.Write("Введите x : "); //информируем пользователя о требуемом действии
        x = Convert.ToDouble(Console.ReadLine()); // считывание строки из консоли
        y = Math.Pow(Math.Cos(x),2) - ((Math.Sqrt(Math.Pow(x,3) + 1) / (Math.Sin(x) + Math.Pow(Math.E, Math.Log(x * 2)))));//вычисление по формуле
        Console.WriteLine("Результат: {0}", y); //вывод результата вычислений
    }
}