using System;
using System.Collections.Generic;

namespace lb3
{
    class Computer
    {
       // private String _name;
        public string Name { get; set; }

        // private int _tasksAmount;
        public int TasksAmount { get; set; }

        // private bool _isReadyToWork;
        public bool IsReadyToWork { get; set; }

        // private List<Task> _tasks;
        internal List<Task> Tasks { get; set; }
        
        public Computer()
        {
            Name = "Комп'ютер";
            IsReadyToWork = true;
            TasksAmount = 1;
        }

        public Computer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool operator == (Computer a, Computer b)
        {
           return (a.Tasks == b.Tasks
                && a.TasksAmount == b.TasksAmount
                && a.IsReadyToWork == b.IsReadyToWork);
             
        }

        public static bool operator !=(Computer a, Computer b)
        {
            if (a.Tasks == b.Tasks
                && a.TasksAmount == b.TasksAmount
                && a.IsReadyToWork == b.IsReadyToWork)
                return false;
            else return true;
        }
    }
}
