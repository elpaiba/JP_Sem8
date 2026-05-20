namespace ejercicio6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el consumo en m3: ");
        double consumo = double.Parse(Console.ReadLine());

        double costo = CalcularCostoAgua(consumo);
        MostrarRecibo(consumo, costo);
    }

    // Función con retorno para calcular el costo
    static double CalcularCostoAgua(double m3)
    {
        if (m3 <= 20)
        {
            return m3 * 1.80;
        }
        else
        {
            return 20 * 1.80 + (m3 - 20) * 2.50;
        }
    }

    // Procedimiento void para mostrar el recibo
    static void MostrarRecibo(double m3, double costo)
    {
        Console.WriteLine("Consumo: " + m3 + " m3");
        Console.WriteLine("Costo total: S/ " + costo.ToString("F2"));
    }
}