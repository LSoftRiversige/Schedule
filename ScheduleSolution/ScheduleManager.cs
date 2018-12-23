using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleSolution
{
    class ScheduleManager : IScheduleManager
    {
        public string Value { get; private set; }

        public ScheduleManager(string value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string GetSchedule()
        {
            return Value;
        }
    }
}
