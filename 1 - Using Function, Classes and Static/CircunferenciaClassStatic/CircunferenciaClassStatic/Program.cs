using System;
using System.Globalization;

namespace CircunferenciaClassStatic {
    class Program {
        static void Main(string[] args) {
            double r;

            Console.Write("Entre o valor do raio: ");
            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Circunferência: " + Calculadora.Circunferencia(r).ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Calculadora.Volume(r).ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
