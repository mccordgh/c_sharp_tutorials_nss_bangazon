using System;

namespace bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime purchaseDate = DateTime.Now;

            string lastName = "Smith";

            var firstName = "Bill";

            Console.WriteLine($"\n{firstName} {lastName} purchased on {purchaseDate}\n");

            string[] products = new string[] {
                "Motorcycle",
                "Sofa",
                "Sandals",
                "Omega Watch",
                "iPhone"
            };

            foreach (string product in products) {
                if (product.Length > 6) {
                    Console.WriteLine($"{product} *");
                } else {
                    Console.WriteLine(product);
                }
            }
        }
    }
}
