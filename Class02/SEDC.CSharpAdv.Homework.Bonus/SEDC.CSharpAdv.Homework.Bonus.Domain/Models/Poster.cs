using SEDC.CSharpAdv.Homework.Bonus.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Bonus.Domain.Models
{
    public class Poster : User, IPoster
    {
        public Poster(string userName) 
        {
            UserName = userName;
            Role = Enumerables.Role.Poster;
        }
        public int Points { get; set; }
        public bool IsPosterOfTheWeek { get; set; }
        public void CheckStats()
        {
            Console.WriteLine($"{UserName} has {Points} points and {Comments.Count} comments");
        }
        public override void PostComment(string comment)
        {
           Comments.Add(comment);
        }
        public override void PrintUser()
        {
            Console.WriteLine($"{UserName} has {Comments.Count} comments");
        }
    }
}
