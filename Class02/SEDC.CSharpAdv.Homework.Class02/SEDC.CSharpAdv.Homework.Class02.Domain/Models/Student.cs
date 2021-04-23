using SEDC.CSharpAdv.Homework.Class02.Domain.Entities;
using SEDC.CSharpAdv.Homework.Class02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Class02.Domain.Models
{
    public class Student : User, IStudent
    {
        public Student(int id, string name, string userName, string password, List <int> grades) : base(id, name, userName, password)
        {
            this.Grades = grades;
        }
        public List<int> Grades { get; set; }

    }
}
