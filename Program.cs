using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace consoleapp
{
    class Person
    {
        public string Name { get; set; }

        public int BirthYear { get; set; }

        public string Intro()
        {
            return $"name: {this.Name} age: {this.CalculateAge()}";
        }

        public int CalculateAge() {
            return DateTime.Now.Year - this.BirthYear;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person() { Name = "Emre", BirthYear = 2001 };
            Person p2 = new Person() { Name = "Zeynep", BirthYear = 2000 };
            Person p3 = new Person() { Name = "Elif İkra", BirthYear = 2010 };

            var str1 = p1.Intro();
            var str2 = p2.Intro();
            var str3 = p3.Intro();

            System.Console.WriteLine(str1 );
            System.Console.WriteLine(str2 );
            System.Console.WriteLine(str3 );

        }


    }
}