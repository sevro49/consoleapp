using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace consoleapp
{
    class Student
    {

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name { get; set; }

        public int Number { get; set; }

        public static string SchoolName = "My School";

        public static string SchoolAdress = "My School Adress";

        public void DisplayStudentDetails()
        {
            System.Console.WriteLine($"name: {this.Name} number: {this.Number}");
        }

        public static void DisplaySchoolDetails()
        {
            System.Console.WriteLine($"School: {SchoolName} address: {SchoolAdress}");
        }

    }

    static class HelperMethods
    {
        public static string FixCharacter(string str)
        {
            return str.ToLower().Replace("ö", "o").Replace("ü", "u").Replace("ç", "c").Replace(" ", "-").Replace("ğ", "g");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // var s1 = new Student("Emre", 100);
            // var s2 = new Student("Zeynep", 102);
            // var s3 = new Student("Ahmet", 103);


            // Student.DisplaySchoolDetails();

            // s1.DisplayStudentDetails();
            // s2.DisplayStudentDetails();
            // s3.DisplayStudentDetails();

            string str = "Ölçme ve Değerlendirme";
            var result = HelperMethods.FixCharacter(str);
            System.Console.WriteLine(result);
        }
    }
}