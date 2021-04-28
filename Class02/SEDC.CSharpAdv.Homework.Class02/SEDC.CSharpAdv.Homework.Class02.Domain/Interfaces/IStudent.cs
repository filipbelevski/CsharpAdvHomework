using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Class02.Domain.Interfaces
{
    public interface IStudent : IUser
    {
        List <int> Grades { get; set; }
    }
}
