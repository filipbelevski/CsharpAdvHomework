using SEDC.CSharpAdv.Homework.Bonus.Domain.Models;
using System;

namespace SEDC.CSharpAdv.Homework.Bonus.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Poster bob = new Poster("BobBobski");
            Moderator jill = new Moderator("JillJill");
            Guest someGuest = new Guest();

            bob.PostComment("comment 1");
            bob.PostComment("comment 2");
            bob.CheckStats();
            jill.BanUser(bob, "bad bob");
            someGuest.ReadComment("comment some comment");

        }
    }
}
