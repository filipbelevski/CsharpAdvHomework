using SEDC.TimeTracker.Data.BaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracker.Data.Models
{
    public class Reading : Activity
    {
        public int PagesRead { get; set; }
        
        public override void ActivityStatistics()
        {
            double hrs = Math.Floor(MinutesSpent / 60);
            double mins = MinutesSpent % 60;

            Console.WriteLine($"You spent {hrs} hours and {mins} reading. Type: {Type}");
        }
    }
}
