using SEDC.TimeTracker.Data.BaseModels;
using SEDC.TimeTracker.Data.DataBase;
using SEDC.TimeTracker.Data.Enumerations;
using SEDC.TimeTracker.Data.Models;
using SEDC.TimeTracker.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace SEDC.TimeTracker.Services.Menus
{
    public class UserService
    {
        private UserRepository _userRepository;
        private Menu _menu;
        public UserService()
        {
            _userRepository = new UserRepository();
            _menu = new Menu();
        }
        public User Login()
        {
            int counter = 0;
            User user = null;
            if (counter == 3)
            {
                _menu.Exit();
            }

            while (counter < 3 && user == null)
            {
                Console.WriteLine("Please enter your username");
                string userName = Console.ReadLine();
                Console.WriteLine("Please enter your password");
                string password = Console.ReadLine();

                user = _userRepository.ValidLogin(userName, password);
                if (user != null)
                {
                    Console.WriteLine($"Welcome {user.FirstName}");
                    _userRepository.Login(user);
                    return user;
                }
                Console.WriteLine("Incorrect username or password");
                Console.WriteLine("Please try again");
                counter++;
            }
            return null;
        }
        public User Register()
        {
            User user = null;
            string userName = Parser.ValidUserName();
            string password = Parser.ValidPassword();
            string fName = Parser.ValidName("first name");
            string lName = Parser.ValidName("last name");
            DateTime dob = Parser.ToDateTime();

            user = new User() { UserName = userName, Password = password, FirstName = fName, LastName = lName, DateOfBirth = dob, IsActiveAccount = true, IsLoggedIn = true };
            _userRepository.Insert(user);

            return user;
        }

        public double StartTrackingTime(string activityName)
        {
            Console.Clear();
            Console.WriteLine($"Press enter to start tracking your {activityName}");
            Console.ReadLine();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine("Press enter to stop the timer");
            Console.ReadLine();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0: 00}H : {1: 00}M : {2:00}S", ts.Hours, ts.Minutes, ts.Seconds);

            double hrs = ts.Hours * 60;
            double minutes = hrs + ts.Minutes;

            Console.WriteLine($"{activityName} {elapsedTime}");
            return minutes;
        }
        public void ReturnCurrentActivity(string activityName, User user)
        {
            double minutes = StartTrackingTime(activityName);
            ;
            string activityType = Parser.ValidName("more info about " + activityName);
            _userRepository.AddActivity(user, Parser.ToActivity(activityName, minutes, activityType));
        }
    }
}
