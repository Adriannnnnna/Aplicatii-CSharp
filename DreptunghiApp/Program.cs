using System;
class Program
{
    static void Main()
    {
        Console.Write("Lungime: ");
        double lungime = double.Parse(Console.ReadLine()!);
        Console.Write("Latime: ");
        double latime = double.Parse(Console.ReadLine()!);
        double arie = lungime * latime;
        Console.WriteLine($"Aria = {arie}");
    }
}
