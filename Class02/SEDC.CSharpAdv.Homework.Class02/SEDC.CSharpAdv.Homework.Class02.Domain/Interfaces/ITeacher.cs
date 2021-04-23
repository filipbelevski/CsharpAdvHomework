using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Class02.Domain.Interfaces
{
    public interface ITeacher : IUser
    {
        string Subject { get; set; }
        string PrintUser()
        {
            return Subject;
        }
    }
}
