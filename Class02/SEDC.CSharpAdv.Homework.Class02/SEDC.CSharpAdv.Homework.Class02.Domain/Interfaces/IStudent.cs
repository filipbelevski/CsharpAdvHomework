using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Class02.Domain.Interfaces
{
    public interface IStudent : IUser
    {
        List <int> Grades { get; set; }

        string PrintUser()
        {
            Console.WriteLine($"{Name} grades are : ");
            foreach (int grade in Grades)
            {
                Console.Write(grade + " ,");
            }
            return string.Empty;
        }
    }
}
