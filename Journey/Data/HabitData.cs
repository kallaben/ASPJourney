using Journey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Journey.Data
{
    public class HabitData
    {
        private static Habit[] _habits = new Habit[]
        {
            new Habit("Go for a run")
            {
                Completed = false
            },
      
            new Habit("Study")
            {
                Completed = true
            },

            new Habit("Meditate")
            {
                Completed = true
            }
        };

        public Habit[] GetHabits()
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
    }
}