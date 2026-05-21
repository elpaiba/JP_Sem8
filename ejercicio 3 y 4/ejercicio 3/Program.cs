namespace ejercicio_3;

using System;

class Program
{
    // Constante: pago por hora
    const double pagoPorHora = 12.50;

    static void Main(string[] args)
    {
        Console.Write("Ingrese horas trabajadas: ");
        int horas = int.Parse(Console.ReadLine());

        // Funciones con retorno
        double bruto = CalcularBruto(horas);
        double descuento = CalcularDescuento(bruto);
        double neto = CalcularNeto(bruto, descuento);

        // Reporte
        Console.WriteLine("\n=== REPORTE DE SUELDO ===");
        Console.WriteLine($"Sueldo Bruto: S/{bruto:F2}");
        Console.WriteLine($"Descuento (5%): S/{descuento:F2}");
        Console.WriteLine($"Sueldo Neto: S/{neto:F2}");
    }

    // Función con retorno: sueldo bruto
    static double CalcularBruto(int horas)
    {
        return horas * pagoPorHora;
    }

    // Función con retorno: descuento 5%
    static double CalcularDescuento(double bruto)
    {
        return bruto * 0.05;
    }

    // Función con retorno: sueldo neto
    static double CalcularNeto(double bruto, double descuento)
    {
        return bruto - descuento;
    }
}
