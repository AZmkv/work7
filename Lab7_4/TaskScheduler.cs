namespace Lab7_4
{
    public class CustomTaskScheduler<TTask, TPriority>
    {
        private readonly SortedDictionary<TPriority, Queue<TTask>> taskQueue = new SortedDictionary<TPriority, Queue<TTask>>();
        private readonly Func<TTask, TPriority> prioritySelector;

        public delegate void TaskExecution(TTask task);

        public CustomTaskScheduler(Func<TTask, TPriority> prioritySelector)
        {
            this.prioritySelector = prioritySelector ?? throw new ArgumentNullException(nameof(prioritySelector));
        }

        public void AddTask(TTask task)
        {
            TPriority priority = prioritySelector(task);

            if (!taskQueue.ContainsKey(priority))
            {
                taskQueue[priority] = new Queue<TTask>();
            }

            taskQueue[priority].Enqueue(task);
        }

        public void ExecuteNext(TaskExecution executeTask)
        {
            if (taskQueue.Count > 0)
            {
                var highestPriority = taskQueue.Keys.Max();
                var nextTask = taskQueue[highestPriority].Dequeue();

                if (taskQueue[highestPriority].Count == 0)
                {
                    taskQueue.Remove(highestPriority);
                }

                executeTask(nextTask);
            }
            else
            {
                Console.WriteLine("No tasks in the queue.");
            }
        }

        public IEnumerable<TTask> GetTasks()
        {
            var tasks = new List<TTask>();
            foreach (var queue in taskQueue.Values)
            {
                tasks.AddRange(queue);
            }
            return tasks;
        }

        public void ReturnToPool(IEnumerable<TTask> tasks)
        {
            foreach (var task in tasks)
            {
                AddTask(task);
            }
        }
    }
}
