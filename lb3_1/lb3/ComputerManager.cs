using System;
using System.Collections.Generic;
using System.Linq;

namespace lb3
{
    static class ComputerManager
    {
        // private static int _amountComputers;
        public static int AmountComputers { get; set; }
        
        // private static int _amountWorkplaces;
        public static int AmountWorkplaces { get; set; }

        // private static bool _isRouterUsed;
        public static bool IsRouterUsed { get; private set; }

        // private static string _wifiPass;
        public static string WiFiPassword { get; private set; }

        // private static  List<Computer> _computers = new List<Computer>();
        public static List<Computer> Computers { get; set; } = new List<Computer>();

        // private static Dictionary<Task, Computer> _tasks = new Dictionary<Task, Computer>();
        public static Dictionary<Task, Computer> Tasks { get; set; } = new Dictionary<Task, Computer>();
        
        // private static string _name;
        public static string Name { get; set; }
       
        public static void SetTask(Task task, Computer computer)
        {
            if (!Computers.Contains(computer)) 
                throw new Exception("Комп'ютер не існує");

            if (task.IsCompleted) 
                throw new Exception("Задачу вже виконано!");
            
            if (!computer.IsReadyToWork) 
                throw new Exception("Комп'ютер не може виконати цю задачу в даний момент!");
          
            else if (Tasks.ContainsKey(task))
                Tasks[task] = computer;
            else
                Tasks.Add(task, computer);

            task.OnComplete += TaskOnComplete; 
            task.Do();
        }

        private static void TaskOnComplete(Task task)
        {
            Tasks.Remove(task);
        }

        public static void RemoveTaskFromComputer(Task task, Computer computer)
        {
            if (Tasks.TryGetValue(task, out computer))
            {
                Tasks.Remove(task);
            }
            else 
                throw new Exception("Невірна задача!");
        }

        public static void AddComputer(Computer computer)
        {
            if (!Computers.Contains(computer))
            {
                Computers.Add(computer);
            }
            else 
                throw new Exception("Комп'ютер вже існує");
        }
        public static void RemoveComputer(Computer computer)
        {
            if (Computers.Contains(computer))
                Computers.Remove(computer);
            else 
                throw new Exception("Комп'ютер не існує");
        }
        public static void AddTask(Task task)
        {
            if (!Tasks.ContainsKey(task))
                Tasks.Keys.Append(task);
            else 
                throw new Exception("Задача вже існує");
        }
        public static void RemoveTask(Task task)
        {
            if (Tasks.ContainsKey(task))
                Tasks.Remove(task);
            else
                throw new Exception("Задача не існує");
        }

        public static Computer CompareComputers(Computer a, Computer b)
        {
            if (a.Tasks.Count >= b.Tasks.Count) 
                return a;
            else 
                return b;
        }

        public static void SetRouter(string password)
        {
            IsRouterUsed = true;
            WiFiPassword = password;
        }

         public static string ToString()
         {
            return Name;
         }

    }
}
