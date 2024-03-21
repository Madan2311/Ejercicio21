using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        char respuesta;
        do
        {
            Console.WriteLine("Ingrese el número de pacientes:");
            int cantidadPacientes = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadPacientes; i++)
            {
                Console.WriteLine($"\nDatos del paciente {i + 1}:");
                Console.WriteLine("Ingrese el peso en kg:");
                double peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura en metros:");
                decimal altura = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double imc = CalcularIMC(peso, altura);
                string categoria = ObtenerCategoriaIMC(imc);

                Console.WriteLine($"El IMC del paciente {i + 1} es: {imc:F2}");
                Console.WriteLine($"Categoría: {categoria}");
            }

            Console.WriteLine("\n¿Quiere volver a calcular? (s/n)");
            respuesta = char.ToLower(Console.ReadKey().KeyChar);
        } while (respuesta == 's');
    }

    static double CalcularIMC(double peso, decimal altura)
    {
        return (double)peso / ((double)altura * (double)altura);
    }

    static string ObtenerCategoriaIMC(double imc)
    {
        if (imc < 18.5)
            return "Peso insuficiente";
        else if (imc >= 18.5 && imc <= 24.9)
            return "Peso saludable";
        else if (imc >= 25.0 && imc <= 29.9)
            return "Sobrepeso";
        else
            return "Obesidad";
    }
}
