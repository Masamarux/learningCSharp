using System;
using System.Globalization;

namespace CircunferenciaClassCalc {
    class Program {
        static void Main(string[] args) {
            Calculadora calc = new Calculadora();

            double r;

            Console.Write("Entre o valor do raio: ");
            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Circunferência: " + calc.Circunferencia(r).ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + calc.Volume(r).ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("f2", CultureInfo.InvariantCulture));
         
        }
    }
}
