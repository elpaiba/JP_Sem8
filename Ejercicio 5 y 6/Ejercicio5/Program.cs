using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la nota: ");
        double nota = double.Parse(Console.ReadLine());

        if (ValidarNota(nota))
        {
            MostrarReporte(nota);
        }
        else
        {
            Console.WriteLine("Error: La nota debe estar entre 0 y 20.");
        }
    }

    // Función con retorno para validar
    static bool ValidarNota(double nota)
    {
        return nota >= 0 && nota <= 20;
    }

    // Función con retorno para clasificar
    static string ClasificarNota(double nota)
    {
        if (nota >= 18 && nota <= 20)
            return "Excelente";
        else if (nota >= 14 && nota <= 17)
            return "Bueno";
        else if (nota >= 11 && nota <= 13)
            return "Regular";
        else
            return "Desaprobado";
    }

    // Función void para mostrar el reporte
    static void MostrarReporte(double nota)
    {
        string clasificacion = ClasificarNota(nota);
        Console.WriteLine("Nota ingresada: " + nota.ToString("F2"));
        Console.WriteLine("Clasificación: " + clasificacion);
    }
}