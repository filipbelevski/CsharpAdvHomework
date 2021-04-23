using SEDC.CSharpAdv.Homework.Class02.Domain.Entities;
using SEDC.CSharpAdv.Homework.Class02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Class02.Domain.Models
{
    public class Teacher : User, ITeacher
    {
        public Teacher(int id, string name, string userName, string password, string subject) : base(id, name, userName, password)
        {
            this.Subject = subject;
        }
        public string Subject {get; set; }

        public string Printuser()
        {
            return Subject;
        }
    }
}
