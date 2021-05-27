using SEDC.TimeTracker.Data.BaseModels;
using SEDC.TimeTracker.Data.DataBase;
using SEDC.TimeTracker.Data.Models;
using SEDC.TimeTracker.Services.Helpers;
using SEDC.TimeTracker.Services.Menus;
using System;

namespace SEDC.TimeTracker.App
{
    class Program
    {
        static void Main(string[] args)
        {
            App();
        }
        static void App()
        {
            UserService userService = new UserService();
            UserRepository userRepository = new UserRepository();
            Menu menu = new Menu();
            User user = null;
            bool isLoggedIn = false;
            while (!isLoggedIn)
            {
                menu.LoginMenu();
                int selection = Parser.ToInteger(1, 3);
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        user = userService.Login();
                        if(user != null)
                        {
                            isLoggedIn = true;
                        }
                        break;
                    case 2:
                        user = userService.Register();
                        if (user != null)
                        {
                            isLoggedIn = true;
                        }
                        break;
                    case 3:
                        menu.Exit();
                        break;
                }
            }

            bool mainMenu = true;
            while (mainMenu)
            {
                menu.MainMenu();
                int selection = Parser.ToInteger(0, 3);
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        menu.ActivityMenu();
                        ActiveTracking(menu, userService, user);
                        mainMenu = true;
                        break;
                    case 2:
                        user.PrintStatistics();
                        mainMenu = true;
                        break;
                    case 3:
                        user.IsLoggedIn = false;
                        mainMenu = false;
                        isLoggedIn = false;
                        App();
                        break;
                    case 0:
                        userRepository.DeactivateAccount(user);
                        menu.DeactivateAccount(user);
                        user.IsLoggedIn = false;
                        isLoggedIn = false;
                        App();
                        break;
                }
            }

        }
        static void ActiveTracking (Menu menu, UserService userService, User user) {
            bool isActive = false;
            while (!isActive)
            {
                menu.ActivityMenu();
                int selection = Parser.ToInteger(0, 3);
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        userService.ReturnCurrentActivity("reading", user);
                        break;
                    case 2:
                        userService.ReturnCurrentActivity("exercising", user);
                        break;
                    case 3:
                        userService.ReturnCurrentActivity("working", user);
                        break;
                    case 4:
                        userService.ReturnCurrentActivity("other hobby", user);
                        break;
                    case 0:
                        isActive = !isActive;
                        break;

                }
            }
        }

    }
}

