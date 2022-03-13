using System;

namespace SumerMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SUPER MERCADO!");
            Console.WriteLine("================");

            Product producto1 = new FixedPriceProduct()
            {
                Description = "Vino Gato Negro",
                Id = 1010,
                Price = 46000,
                Tax = 0.19F
            };

            Console.WriteLine(producto1);
        }
    }
}
