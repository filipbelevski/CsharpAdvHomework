using SEDC.CSharpAdv.Homework.Bonus.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdv.Homework.Bonus.Domain.Interfaces
{
    public interface IModerator
    {
        List<User> Users { get; set; }
        void BanUser(User user, string reason);
    }
}
