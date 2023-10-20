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
        private string _name;
        public string Name{
            get{
                return _name;
            }

            set{
                if(!string.IsNullOrEmpty(value)){
                    _name = value;
                } else {
                    throw new Exception("Please enter name!");
                }
            }
        }
        
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value < 0)
            {
                _price = 0;
            }
            else
            {
                _price = value;
            }
            }
        }

        public bool IsApproved { get; set; }
        
        // public void setPrice(double price)
        // {
        //     if (price < 0)
        //     {
        //         this.Price = 0;
        //     }
        //     else
        //     {
        //         this.Price = price;
        //     }
        // }

        // public double GetPrice(){
        //     return this.Price;
        // }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var p = new Product();
            p.Name = "Samsung S7";
            p.Price = 2000;
            System.Console.WriteLine(p.Name);
            System.Console.WriteLine(p.Price);
        }
    }
}