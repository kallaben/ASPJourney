using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Journey.Models
{
    public class Habit
    {
        static int globalId = 1;
        private int _id;
        private string _name;
        private bool _completed;
        private int _dayCount = 0;

        public Habit(string name)
        {
            _name = name;
            _completed = false;
            _id = globalId;
            globalId++;
        }

        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int DayCount { get { return _dayCount; } }

        public int Id { get { return _id; } }
    }
}