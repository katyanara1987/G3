using System;
using System.Collections.Generic;
using System.Text;

    public class Task   
    {
        private string _name;
        private int _priority;
        private int _duration;

        public Task(string name, int priority, int duration) 
        {
            Name = name;
            Priority = priority;
            Duration = duration;
        }

        public string Name 
        {
            get 
            {
                return _name;
            }
            private set 
            {
                _name = value;
            }
        }

        public int Priority
        {
            get
            {
                return _priority;
            }
            private set
            {
                _priority = value;
            }
        }

        public int Duration 
        {
            get 
            {
                return _duration;
            }
            private set
            {
                _duration = value;
            }
        }


    }

