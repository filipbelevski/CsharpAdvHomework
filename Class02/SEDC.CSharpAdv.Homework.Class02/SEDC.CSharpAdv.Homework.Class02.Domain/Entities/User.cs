using SEDC.CSharpAdv.Homework.Class02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Class02.Domain.Entities
{
    public abstract class User : IUser
    {
        public User(int id, string name, string userName, string password)
        {
            this.Id = id;
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
        }
        public int Id { get;set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public abstract string PrintUser();
    }
}
