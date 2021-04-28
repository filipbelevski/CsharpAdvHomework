using SEDC.CSharpAdv.Homework.Bonus.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Bonus.Domain.Models
{
    public class Guest : User, IGuest
    {
        public int Id { get; set; }
        public Guest()
        {
            Id = new Random().Next(1, 32000);
            Role = Enumerables.Role.Guest;
        }

        public override void PostComment(string comment)
        {
            throw new Exception("Guests cannot post");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Guest #{Id}");
        }
        

        public void ReadComment(string comment)
        {
            Console.WriteLine($"The guest with Id: {Id} read this comment: {comment}");
        }
    }
}
