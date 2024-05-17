using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        int num3 = int.Parse(Console.ReadLine());

        // Determinar el mayor
        int mayor = num1;
        if (num2 > mayor)
        {
            mayor = num2;
        }
        if (num3 > mayor)
        {
            mayor = num3;
        }

        // Determinar el menor
        int menor = num1;
        if (num2 < menor)
        {
            menor = num2;
        }
        if (num3 < menor)
        {
            menor = num3;
        }

        Console.WriteLine($"El número mayor es: {mayor}");
        Console.WriteLine($"El número menor es: {menor}");

        Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
    }
}