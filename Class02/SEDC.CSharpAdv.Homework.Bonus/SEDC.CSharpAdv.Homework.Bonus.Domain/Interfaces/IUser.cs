using SEDC.CSharpAdv.Homework.Bonus.Domain.Enumerables;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Bonus.Domain
{
    public interface IUser
    {
        string UserName { get; set; }
        Role Role { get; set; }
        List<string> Comments { get; set; }
        void PostComment(string comment);
        void PrintUser();

    }
}
