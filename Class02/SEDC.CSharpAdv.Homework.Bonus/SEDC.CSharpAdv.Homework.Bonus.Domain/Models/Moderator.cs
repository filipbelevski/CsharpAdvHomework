using SEDC.CSharpAdv.Homework.Bonus.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Bonus.Domain.Models
{
    public class Moderator : User, IModerator
    {
        public List<User> Users { get ; set ; }

        public Moderator(string userName)
        {
            UserName = userName;
            Role = Enumerables.Role.Moderator;
        }
        public void BanUser(User user, string reason)
        {
            Console.WriteLine($"{user.UserName} was banned for {reason}");
        }

        public override void PostComment(string comment)
        {
            Comments.Add(comment);
        }

        public override void PrintUser()
        {
            Console.WriteLine($"{UserName} {Comments.Count}");
        }
    }
}
