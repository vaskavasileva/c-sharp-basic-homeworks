using HabitTracker.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Entities
{
    public class Habit
    {
        public string Title { get; set; }
        public Group Group { get; set; }
        public Difficulty Difficulty { get; set; }
        public HabitType Type { get; set; }
        public Dictionary<DateTime, bool> DailyLog { get; set; } = new Dictionary<DateTime, bool>();

    }
}
