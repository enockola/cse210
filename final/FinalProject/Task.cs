    public abstract class Task
    {
        protected string _taskDescription;
        protected string _taskPriority;
        protected string _taskDate;

        protected Task() { }

        protected Task(string taskDescription, string taskPriority, string taskDate)
        {
            _taskDescription = taskDescription;
            _taskPriority = taskPriority;
            _taskDate = taskDate;
        }

        public string GetTaskDescription()
        {
            return _taskDescription;
        }

        public string GetTaskPriority()
        {
            return _taskPriority;
        }

        public string GetTaskDate()
        {
            return _taskDate;
        }

        public abstract void InputDetails();
        public abstract string GetExtraInfo();
        
        public void UpdateDetails(string newDescription, string newPriority)
        {
            _taskDescription = newDescription;
            _taskPriority = newPriority;
        }

        public override string ToString()
        {
            return $"{_taskDescription}, Priority: {_taskPriority}, Date: {_taskDate}";
        }
    }