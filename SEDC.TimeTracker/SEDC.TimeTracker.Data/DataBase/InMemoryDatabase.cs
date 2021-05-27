using SEDC.TimeTracker.Data.BaseModels;
using SEDC.TimeTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracker.Data.DataBase
{
    public static class InMemoryDatabase
    {
        public static int userId = 1;
        public static List<User> Users { get; set; }
        static InMemoryDatabase()
        {
            InitDataBase();
        }
        private static void InitDataBase()
        {
            Users = new List<User>
            {
                new User() {Id = userId, FirstName = "Filip", LastName = "Belevski", UserName = "fichho", Password = "ASD123", DateOfBirth = new DateTime(1994, 04, 23), Activities = new List<Activity>() {
                     new Exercising() {Type = "Running", MinutesSpent = 30}
                } }
            };
        }
    }
}
