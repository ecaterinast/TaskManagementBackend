using TaskManagement.Data.DbModels;
using TaskManagement.Interfaces;

namespace TaskManagement.Handlers
{
    public class HighPriorityHandler : ITaskHandler
    {
        private ITaskHandler _nextHandler;
        public bool Handle(BaseTask task)
        {
            if (task.Priority == TaskPriority.High)
            {
                Console.WriteLine("Handling High priority task");
                return true;
            }
            else if (_nextHandler != null)
            {
                return _nextHandler.Handle(task);
            }
            return false;

        }

        public void SetNextHandler(ITaskHandler handler)
        {
            _nextHandler = handler;
        }
    }
}
