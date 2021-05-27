using SEDC.TimeTracker.Data.BaseModels;
using SEDC.TimeTracker.Data.DataBase;
using SEDC.TimeTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TimeTracker.Services.Helpers
{
    public static class Parser
    {
        public static int ToInteger(int min, int max)
        {
            while (true)
            {
                int parsedNum = ValidateInput(Console.ReadLine(), min, max);
                if(parsedNum != -1)
                {
                    return parsedNum;
                }
            }
        }
        private static int ValidateInput(string input, int min, int max)
        {
            int parsedNumber = -1;
            try
            {
                parsedNumber = int.Parse(input);
                if (!(parsedNumber >= min && parsedNumber <= max))
                {
                    throw new Exception($"Please select from the given range from {min} to {max}");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter argument");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not valid input");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is to large or to low");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return parsedNumber;
        }
        public static DateTime ToDateTime()
        {
            while (true)
            {
                Console.Write("Enter year: ");
                int year = ToInteger(1900, DateTime.Now.Year - 18);
                Console.Write("\nEnter month: ");
                int month = ToInteger(1, 12);
                Console.Write("\nEnter day: ");
                int day = ToInteger(1, DateTime.DaysInMonth(year, month));
                try
                {
                    DateTime dob = new DateTime(year, month, day);
                    return dob;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not valid input");
                }
            }
        }
        public static string ValidUserName()
        {
            UserRepository _userRepository = new UserRepository();
            while (true)
            {
                Console.WriteLine("Enter username (must be 5-12 characters long)");
                string userName = Console.ReadLine();
                try
                {
                    if(userName.Length >= 5 && userName.Length < 12)
                    {
                        if (_userRepository.IsValidNewUserName(userName))
                        {
                            return userName;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
        public static string ValidPassword()
        {
            while (true)
            {
                Console.WriteLine("Enter password (must contain one capital letter, one number and be at least 6 characters long");
                string password = Console.ReadLine();
                try
                {
                    if (password.Length >= 6 && password.Any(char.IsDigit) && password.Any(char.IsUpper))
                    {
                        return password;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
        public static string ValidName(string nameType)
        {
            while (true)
            {
                Console.WriteLine($"Enter {nameType}");
                string name = Console.ReadLine();
                try
                {
                    if(name.Length > 2 && !(name.Any(char.IsDigit)))
                    {
                        return name;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }

        public static Activity ToActivity(string activityInput, double timeSpent, string activityType)
        {
            
            switch (activityInput.ToLower())
            {
                case "exercising":
                    return new Exercising() { MinutesSpent = timeSpent, Type = activityType};
                case "reading":
                    return new Reading() { MinutesSpent = timeSpent, Type = activityType };
                case "working":
                    return new Working() { MinutesSpent = timeSpent, Type = activityType };
                case "other_hobbies":
                    return new OtherHobby() { MinutesSpent = timeSpent, Type = activityType };
            }
            return null;

        }
    }
}
