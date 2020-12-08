using System;
using System.Collections.Generic;

namespace PolyPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            var payableObjects = new List<iPayable>()
            {
                new Invoice("01234", "Seat", 2, 375.00M),
                new Invoice("56789", "Tire", 4, 79.98M),
                new Invoice("111213", "Breaks", 15, 183.33M),
                new SalariedEmployee("John", "Smith", "111-11-1111", 800.00M),
                new SalariedEmployee("Lisa", "Barnes", "222-22-2222", 1200.00M),
                new SalariedEmployee("Marge", "Parge", "333-33-3333", 2400.00M),
                new HourlyEmployee("Chaz", "Bono", "444-44-4444", 23M, 40), 
                new HourlyEmployee("Bill", "Bixby", "555-55-5555", 23M, 63), 
                new HourlyEmployee("John", "Schmon", "666-66-6666", 66M, 40) };

    Console.WriteLine("Invoices and Employees processed:\n");

            foreach (var payable in payableObjects)
            {
                Console.WriteLine($"{payable}");
                Console.WriteLine($"Payment Due: {payable.GetPaymentAmount():C}\n");
            }
        }
    }
}
