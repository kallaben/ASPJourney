using Journey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Journey.Data
{
    public class HabitData
    {
        private static List<Habit> _habits = new List<Habit>
        {
            new Habit{Name = "Go for a run", Interval = "daily" },
        };

        public List<Habit> GetHabits()
        {
            return _habits;
        }

        public Habit GetHabit(int id)
        {
            Habit habitToReturn = null;
            foreach (var habit in _habits)
            {
                if (habit.Id == id)
                {
                    habitToReturn = habit;
                    break;
                }
            }
            return habitToReturn;
        }

        public void DeleteHabit(int id)
        {
            foreach (var habit in _habits)
            {
                if (habit.Id == id)
                {
                    _habits.Remove(habit);
                    return;
                }
            }
        }

        public void AddHabit(Habit habit)
        {
            _habits.Add(habit);
        }
    }
}