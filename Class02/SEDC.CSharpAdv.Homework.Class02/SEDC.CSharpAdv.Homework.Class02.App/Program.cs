using System;
using System.Collections.Generic;
using SEDC.CSharpAdv.Homework.Class02.Domain;
using SEDC.CSharpAdv.Homework.Class02.Domain.Interfaces;
using SEDC.CSharpAdv.Homework.Class02.Domain.Models;

namespace SEDC.CSharpAdv.Homework.Class02.App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> filipsGrades = new List<int> { 4, 3, 5, 1 };
            List<int> bobsGrades = new List<int> { 1, 5, 5, 2 };
            IStudent filip = new Student(5, "Filip","filipbelevski", "asd123", filipsGrades);
            IStudent bob = new Student(1, "Bob", "bobbobski", "asd123", bobsGrades);
            ITeacher trajan = new Teacher(1, "Trajan", "traSte", "123asd", "SeeSharp");
            ITeacher neo = new Teacher(2, "Neo", "neoFromMatrix", "123902381903812903890132kojasdkljasiodjasiodjas9832193812930128", "Into the Matrix");

            Console.WriteLine(filip.PrintUser());
            Console.WriteLine(bob.PrintUser());
            Console.WriteLine("============================");
            Console.WriteLine(trajan.PrintUser());
            Console.WriteLine(neo.PrintUser());

            
            
            Console.ReadLine();
        }
    }
}
