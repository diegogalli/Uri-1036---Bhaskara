using System;
using System.Globalization;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Delta, Raiz1, Raiz2;

            string[] vet = Console.ReadLine().Split(' ');

            //Console.WriteLine("Primeiro Valor: ");
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);

            //Console.WriteLine("Segundo Valor: ");
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);

           //Console.WriteLine("Terceiro Valor: ");
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Delta = Math.Pow(B, 2.0) - 4 * A * C; // Δ = b² - 4.A.C

            if ( A == 0 || Delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Raiz1 = (-B + Math.Sqrt(Delta)) / (2.0 * A); // -b + √Δ / 2a
                Console.WriteLine("R1 = " + Raiz1.ToString("F5", CultureInfo.InvariantCulture));
                Raiz2 = (-B - Math.Sqrt(Delta)) / (2.0 * A); // -b - √Δ / 2a
                Console.WriteLine("R2 = " + Raiz2.ToString("F5", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
