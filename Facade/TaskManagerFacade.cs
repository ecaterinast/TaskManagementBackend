using TaskManagement.Data.Models;

namespace TaskManagement.Facade
{
    public class TaskManagerFacade
    {
        private CompositeTask _rootTask;

        public TaskManagerFacade() 
        {
            _rootTask = new CompositeTask();
        }
    }
}
