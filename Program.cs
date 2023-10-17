using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleapp
{
    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; } 

        public string Description { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product[] products = new Product[quantity];
            int i = 0;

            Product prd;

            do{
                prd = new Product();
                System.Console.WriteLine("product name: ");
                prd.Name = Console.ReadLine();

                System.Console.WriteLine("product price: ");
                prd.Price = double.Parse(Console.ReadLine());

                System.Console.WriteLine("product description: ");
                prd.Description = Console.ReadLine();

                products[i] = prd;
                i++;
            } while (quantity > i);

            System.Console.WriteLine("------------------------");

            foreach(var prdt in products){
                System.Console.WriteLine($"{prdt.Name} {prdt.Price} {prdt.Description}");
            }




        }


    }
}