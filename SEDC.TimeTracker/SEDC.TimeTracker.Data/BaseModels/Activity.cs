using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracker.Data.BaseModels
{
    public abstract class Activity : BaseEntity
    { 
        public double MinutesSpent { get; set; }
        public string Type { get; set; }

        public abstract void ActivityStatistics();
    }
}
