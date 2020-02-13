using System;
using System.Globalization;
using RentalCarsWithInterface.Entities;
using RentalCarsWithInterface.Services;

namespace RentalCarsWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string model;
            DateTime start, finish;
            double dayP, hourP;

            CarRental carRental;
            RentalService rentalService;

            Console.WriteLine("Enter rental data: ");
            Console.Write("Car Model: ");
            model = Console.ReadLine();
            Console.Write("Pickup (dd/mm/yyyy hh:mm): ");
            start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/mm/yyyy hh:mm): ");
            finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            carRental = new CarRental(start, finish, new Vehicle(model));

            Console.Write("Enter price per hour: ");
            hourP = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            dayP = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            rentalService = new RentalService(hourP, dayP, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
