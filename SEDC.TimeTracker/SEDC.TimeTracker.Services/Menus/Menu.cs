
using SEDC.TimeTracker.Data.Enumerations;
using SEDC.TimeTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SEDC.TimeTracker.Services.Menus
{
    public class Menu
    {
        public void LoginMenu()
        {
            Console.WriteLine("============ Time Tracking App ============");
            Console.WriteLine();
            Console.WriteLine("1. Log In");
            Console.WriteLine("2. Register");
            Console.WriteLine();
            Console.WriteLine("3. Exit");
        }
        public void MainMenu()
        {
            Console.WriteLine("============ Time Tracking App ============");
            Console.WriteLine("");
            Console.WriteLine("1. Start Tracking an Activity");
            Console.WriteLine("2. View all statistics");

            Console.WriteLine("3. Logout");
            Console.WriteLine("0. Deactivate Account");
        }
        public void ActivityMenu()
        {
            Console.Clear();
            Console.WriteLine("============ Time Tracking App ============");
            Console.WriteLine("");
            int counter = 1;
            foreach(var item in Enum.GetNames(typeof(ActivityTypes)))
            {
                Console.WriteLine($"{counter} {item}");
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("0. Back to Main Menu");
        }
        public void Logout()
        {
            Console.WriteLine("============ Time Tracking App ============");
            Console.WriteLine("Thank you for using the app, see you soon !!");
            Console.WriteLine("Logging out..");
            Thread.Sleep(3000);
        }
        public void Exit()
        {
            Console.WriteLine("============ Time Tracking App ============");
            Console.WriteLine("Thank you for using the app, see you soon !!");
            Thread.Sleep(3000);
            Environment.Exit(0);
        }
        public void DeactivateAccount(User user)
        {
            Console.WriteLine("============ Time Tracking App ============");
            Console.WriteLine($"We are sorry to see you go {user.FirstName}");
            Thread.Sleep(2000);
        }
        public static void ClearScreen()
        {
            Console.Clear();
            Console.WriteLine("============ Time Tracking App ============");
        }

    }
}
