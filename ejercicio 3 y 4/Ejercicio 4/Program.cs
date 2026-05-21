namespace Ejercicio_4;

using System;

class Program
{
    // Constantes
    const double tipoCambio = 3.75;   // S/ por dólar
    const double porcentajeComision = 0.02; // 2%

    static void Main(string[] args)
    {
        Console.Write("Ingrese monto en soles: ");
        double soles = double.Parse(Console.ReadLine());

        // Cálculos con funciones
        double comision = CalcularComision(soles);
        double netoSoles = CalcularNetoSoles(soles, comision);
        double dolares = CalcularDolares(netoSoles);

        // Reporte
        Console.WriteLine("\n=== RECIBO DE CAMBIO ===");
        Console.WriteLine($"Comisión: S/{comision:F2}");
        Console.WriteLine($"Soles netos: S/{netoSoles:F2}");
        Console.WriteLine($"Dólares recibidos: ${dolares:F2}");
    }

    // Función con retorno: comisión
    static double CalcularComision(double soles)
    {
        return soles * porcentajeComision;
    }

    // Función con retorno: soles netos
    static double CalcularNetoSoles(double soles, double comision)
    {
        return soles - comision;
    }

    // Función con retorno: dólares recibidos
    static double CalcularDolares(double netoSoles)
    {
        return netoSoles / tipoCambio;
    }
}
