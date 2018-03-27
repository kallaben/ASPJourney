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
        private bool _completed = false;
        private int _dayCount = 0;
        private string _interval;


        public Habit()
        {
            //_name = name;
            _id = globalId;
            globalId++;
            //_interval = interval;
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

        public string Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        public int DayCount { get { return _dayCount; } }

        public int Id { get { return _id; } }
    }
}