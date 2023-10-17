using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleapp
{
    class Student
    {
        public int StuID { get; set; }

        public string Name { get; set; }

        public string Branch { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            Student stu1 = new Student();
            stu1.StuID = 49;
            stu1.Name = "Emre";
            stu1.Branch = "12";

            System.Console.WriteLine($"Id: {stu1.StuID} name: {stu1.Name} branch: {stu1.Branch}");

            Student stu2 = new Student(){
                StuID = 200,
                Name = "Zeynep",
                Branch = "13"
            };

            System.Console.WriteLine($"Id: {stu2.StuID} name: {stu2.Name} branch: {stu2.Branch}");

            Student stu3 = new Student(){
                StuID = 300,
                Name = "Elif",
                Branch = "8"
            };

            System.Console.WriteLine($"Id: {stu3.StuID} name: {stu3.Name} branch: {stu3.Branch}");

            System.Console.WriteLine("----------------------------------------------------");

            Student[] students = new Student[3];
            students[0] = stu1;
            students[1] = stu2;
            students[2] = stu3;

            foreach(var student in students){
                System.Console.WriteLine($"Id: {student.StuID} name: {student.Name} branch: {student.Branch}");
            }
        }


    }
}