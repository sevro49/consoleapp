using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace consoleapp
{
    class Comment{
        public int Id { get; set; }

        public string Text { get; set; }
    }

    class Product
    {
        public Product()
        {
            this.Id = (new Random()).Next(11111,99999);
            this.Comments = new Comment[3];
        }

        public Product(int Id):this()
        {
            this.Id = Id;
        }

        public Product(int Id, string Name, double Price, bool IsApproved):this(Id)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.IsApproved = IsApproved;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public bool IsApproved { get; set; }

        public Comment[] Comments { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Comment{ Id = 1, Text = "nice product"};
            
            var p1 = new Product();
            p1.Comments[0] = c1;

            var p2 = new Product(12314);
            var p3 = new Product(143242, "Iphone 15", 200, true);
            System.Console.WriteLine(p1.Id);
            System.Console.WriteLine(p1.Name);
            System.Console.WriteLine(p1.Price);
            System.Console.WriteLine(p1.IsApproved);
            System.Console.WriteLine(p1.Comments[0].Text);
            System.Console.WriteLine("**********************");
            System.Console.WriteLine(p2.Id);
            System.Console.WriteLine(p2.Name);
            System.Console.WriteLine(p2.Price);
            System.Console.WriteLine(p2.IsApproved);
            System.Console.WriteLine("**********************");
            System.Console.WriteLine(p3.Id);
            System.Console.WriteLine(p3.Name);
            System.Console.WriteLine(p3.Price);
            System.Console.WriteLine(p3.IsApproved);
            
        }
    }
}