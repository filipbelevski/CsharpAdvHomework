using SEDC.CSharpAdv.Homework.Bonus.Domain.Enumerables;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Bonus.Domain.Models
{
    public abstract class User : IUser
    {
        public User()
        {

        }
        public string UserName { get ; set; }
        public Role Role { get; set; }
        public List<string> Comments { get; set; } = new List<string>();

        public abstract void PostComment(string comment);

        public abstract void PrintUser();
    }
}
