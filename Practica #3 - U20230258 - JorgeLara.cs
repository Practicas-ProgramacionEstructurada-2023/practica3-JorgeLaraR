using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaracion de variables
            string? Marca_Zapato;
            string? Color_Zapato;
            int Cantidad;
            double Precio_Zapato;

            //Capturando datos
            Console.WriteLine("\n------- Capturando Variables -------\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingrese la marca de zapatos a comprar:\n");
            Marca_Zapato = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el color del par de zapatos:\n");
            Color_Zapato = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de pares de zapatos a comprar:\n");
            Console.ForegroundColor = ConsoleColor.Green;            
            Cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del par de zapatos a comprar:\n");
            Precio_Zapato = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ResetColor();
            Console.WriteLine("------- Fin de capturacion de Variables -------\n");

            //Capturando el total a pagar
            double Total = Cantidad * Precio_Zapato;

            //Imprimiendo resultando
            Console.WriteLine("\n------- Imprimiendo resultados -------\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nLa marca de zapatos a comprar es: " + Marca_Zapato);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nEl color de zapatos a comprar es: " + Color_Zapato);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCantidad de pares de zapatos a comprar es: " + Cantidad);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEl precio por par de zapatos a comprar es: " + Precio_Zapato);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El total a pagar es: " + Total);
            Console.ResetColor();
            Console.WriteLine("------- Fin de imprimir resultados -------\n");
        }
    }
}