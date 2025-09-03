using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // --- Підпункт 1 ---
        Console.WriteLine("Підпункт 1. Типи: a – short, b – int, c – long");

        Console.Write("Введіть a (short): ");
        short a1 = short.Parse(Console.ReadLine()!);

        Console.Write("Введіть b (int): ");
        int b1 = int.Parse(Console.ReadLine()!);

        Console.Write("Введіть c (long): ");
        long c1 = long.Parse(Console.ReadLine()!);

        int sum = a1 + b1;
        int diff = a1 - b1;
        long expr1 = (long)a1 + b1 - c1;

        Console.WriteLine($"a + b     = {sum}");//$ перед лапками означает интерполяцию строк
        Console.WriteLine($"a - b     = {diff}");
        Console.WriteLine($"a + b - c = {expr1}");

        Console.WriteLine();

        // --- Підпункт 2 ---
        Console.WriteLine("Підпункт 2. Типи: a – int, b – double");
        Console.WriteLine("Примітка: для дробових чисел можна вводити з комою або крапкою.");

        Console.Write("Введіть a (int): ");
        int a2 = int.Parse(Console.ReadLine()!);

        Console.Write("Введіть b (double): ");
        string? s = Console.ReadLine();
        double b2 = double.Parse(s!.Replace(',', '.'), CultureInfo.InvariantCulture);

        double prodExact = a2 * b2;
        double expr2 = a2 / b2 + 5.0;

        Console.WriteLine($"a * b     = {prodExact}");
        Console.WriteLine($"a / b + 5 = {expr2:F6}");
    }
}