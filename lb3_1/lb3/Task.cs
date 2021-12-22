using System;
using System.Threading;

namespace lb3
{
    class Task : ICloneable
    {
      

        public delegate void TaskHandler(Task task);
        public event TaskHandler OnComplete;

        // private int _timeComplete;
        public int TimeComplete { get; set; }

        // private DateTime _dateComplete;
        public DateTime DateCompleted { get; private set; }

        // private string _name;
        public String Name { get; set; }

        // private bool _isCompleted = false;
        public bool IsCompleted { get; private set; }

        // private string _additionalInfo;
        public string AdditionalInfo { get; set ; }

        public Task()
        {
            Name = "Task";
            TimeComplete = 0;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Do()
        {
            if (IsCompleted == false)
            {
                Thread exeThread = new Thread(new ThreadStart(Execution));
                exeThread.Start();
            }
            
        }
        private void Execution()
        {
            Thread.Sleep(TimeComplete * 1000);
            DateCompleted = DateTime.Now;
            IsCompleted = true;
            OnComplete?.Invoke(this);
        }

        public override string ToString()
        {
            return $"{Name}, {IsCompleted.ToString()}";
        }
    }
}
