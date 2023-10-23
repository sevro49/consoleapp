using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace consoleapp
{
    class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public bool isApproved { get; set; }

    }

    static class ProductManager
    {
        static Product[] Products;

        static ProductManager()
        {
            Products = new Product[5];

            Products[0] = new Product { ProductId = 1, ProductName = "Iphone 6", Price = 3000, isApproved = false };
            Products[1] = new Product { ProductId = 2, ProductName = "Iphone 7", Price = 4000, isApproved = false };
            Products[2] = new Product { ProductId = 3, ProductName = "Iphone 8", Price = 5000, isApproved = true };
            Products[3] = new Product { ProductId = 4, ProductName = "Iphone X", Price = 6000, isApproved = true };
            Products[4] = new Product { ProductId = 5, ProductName = "Iphone 5", Price = 2000, isApproved = true };
        }

        public static Product[] GetProducts()
        {
            return Products;
        }

        public static Product GetProductById(int id)
        {
            Product product = null;

            foreach (var p in Products)
            {
                if (p.ProductId == id)
                    product = p;

            }
            return product;
        }

        public static Product GetProductByName(string name)
        {
            Product product = null;

            foreach (var p in Products)
            {
                if (p.ProductName == name)
                    product = p;

            }
            return product;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            // var products = ProductManager.GetProducts();
            // var product = ProductManager.GetProductById(2);

            // System.Console.WriteLine($"name: {product.ProductName} price: {product.Price}");
            // foreach (var p in products)
            // {
            //     System.Console.WriteLine($"name: {p.ProductName} price: {p.Price}");
            // }

            var product = ProductManager.GetProductByName("Iphone");
            System.Console.WriteLine($"name: {product.ProductName} price: {product.Price}");


        }
    }
}