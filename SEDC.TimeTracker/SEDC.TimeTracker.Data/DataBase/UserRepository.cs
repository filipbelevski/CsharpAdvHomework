using SEDC.TimeTracker.Data.BaseModels;
using SEDC.TimeTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TimeTracker.Data.DataBase
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository()
            : base(InMemoryDatabase.Users, InMemoryDatabase.userId)
        {
        }

        public void AddNewActivity(User user, Activity activity)
        {
            InMemoryDatabase.Users.First(x => x == user).Activities.Add(activity);
        }
        public void ShowCurrentActivityStatistics(User user, Activity activity)
        {
            InMemoryDatabase.Users.First(x => x == user).Activities.First(a => a == activity).ActivityStatistics();
        }
        public void ShowAllActivityStatistics(User user)
        {
            user.Activities.ForEach(x => x.ActivityStatistics());
        }
        public void DeactivateAccount(User user)
        {
            InMemoryDatabase.Users.First(x => x == user).IsActiveAccount = false;
        }
        public void Login(User user)
        {
            InMemoryDatabase.Users.First(x => x == user).IsLoggedIn = true;
        }
        public User ValidLogin(string userName, string password)
        {
            return InMemoryDatabase.Users.FirstOrDefault(x => x.UserName.ToLower() == userName.ToLower() && x.Password == password);
        }
        public void Logout(User user)
        {
            InMemoryDatabase.Users.First(x => x == user).IsLoggedIn = false;
        }
        public bool IsValidNewUserName(string userName)
        {
            bool userNameIsNotTaken = !(InMemoryDatabase.Users.Any(x => x.UserName.ToLower() == userName.ToLower()));
            if (!userNameIsNotTaken)
            {
                Console.WriteLine($"Username {userName} is already taken");
            }
            return userNameIsNotTaken;
        }
        public void AddActivity (User user, Activity activity)
        {
            User tempUser = InMemoryDatabase.Users.First(x => x.Id == user.Id);
            Activity tempActivity = tempUser.Activities.FirstOrDefault(x => x.Type == activity.Type);
            if(tempActivity == null)
            {
                tempUser.Activities.Add(activity);
            }
            else
            {
                tempActivity.MinutesSpent += activity.MinutesSpent;
            }
        }
    }
}
