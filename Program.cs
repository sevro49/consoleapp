using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace consoleapp
{
    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public bool IsAutoTransmission { get; set; }

        public void Start()
        {
            System.Console.WriteLine($"{this.Brand} {this.Model} was started");
        }

        public void Stop()
        {
            System.Console.WriteLine($"{this.Brand} {this.Model}was stopped");
        }

        public void SlowDown()
        {
            System.Console.WriteLine($"{this.Brand} {this.Model} is slowing down");
        }

        public void Accelerate()
        {
            System.Console.WriteLine($"{this.Brand} {this.Model} is accelerating");
        }

        public void Menu()
        {
            string command = "";

            do
            {
                System.Console.WriteLine("Pick one of options 1-Start 2-Accelerate 3-Slow Down 4-Stop (e/E = exit)");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        this.Start();
                        break;
                    case "2":
                        this.Accelerate();
                        break;
                    case "3":
                        this.SlowDown();
                        break;
                    case "4":
                        this.Stop();
                        break;
                    default:
                        System.Console.WriteLine("Program stopped");
                        break;
                }
            } while (command.ToLower() != "e");
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            var opel = new Car() { Brand = "Opel", Model = "Astra", Color = "White", IsAutoTransmission = true };
            // opel.Start();
            // opel.Stop();
            // opel.SlowDown();
            // opel.Accelerate();
            // opel.Menu();

            var mazda = new Car() { Brand = "Mazda", Model = "Rx-7", Color = "Red", IsAutoTransmission = true };
            mazda.Menu();
        }


    }
}