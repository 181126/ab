using System;
public class Poo
{
    static void Main(string[] args)
    {
        Console.Write("Informe o primeiro valor: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        int b = int.Parse(Console.ReadLine());
        int result = a / b;
        Console.WriteLine(result);

        Console.ReadKey();
    }
}
