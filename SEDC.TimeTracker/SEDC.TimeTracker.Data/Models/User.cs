using SEDC.TimeTracker.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TimeTracker.Data.Models
{
    public class User : BaseEntity
    {
        public bool IsLoggedIn { get; set; }
        public bool IsActiveAccount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Activity> Activities { get; set; } = new List<Activity>();
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public User()
        {
            SetAge();
        }
        private void SetAge ()
        {
            DateTime today = DateTime.Now;
            int yearNow = today.Year;
            int monthNow = today.Month;
            int dayNow = today.Day;

            int userYear = DateOfBirth.Year;
            int userMonth = DateOfBirth.Month;
            int userDay = DateOfBirth.Day;


            Age = yearNow - userYear;
            if (userMonth < monthNow)
            {
                if (userDay <= dayNow)
                {
                    return;
                }
            }
            if (userMonth >= monthNow)
            {
                if (userDay > dayNow)
                {
                    Age -= 1;
                }
            }
        }
        public void PrintStatistics()
        {
            if(Activities.Count < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You don't have any activities to track");
                Console.ResetColor();
                return;
            }
            foreach(var activity in Activities)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                activity.ActivityStatistics();
                Console.ResetColor();
            }
        }
    }
}
