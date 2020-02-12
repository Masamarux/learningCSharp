using System;
using System.Globalization;

namespace CircunferenciaStaticFunc {
    class Program {

        static double Pi = 3.14;
        static void Main(string[] args) {
            double r;

            Console.Write("Entre o valor do raio: ");
            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Circunferência: " + Circunferencia(r).ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Volume(r).ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("f2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double raio) {
            return 2.0 * raio * Pi;
        }
        static double Volume(double raio) {
            return (4.0 * Pi * raio * raio * raio) / 3.0;
        }
    }
}
