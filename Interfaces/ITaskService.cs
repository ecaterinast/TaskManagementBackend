using TaskManagement.Data.DbModels;

namespace TaskManagement.Interfaces
{
    public interface ITaskService
    {
        void AddTask(BaseTask task);
        
        void RemoveTask(string name);
        List<ItemTask> GetAllTasks();

        int CalculateTotalHours(); // Composite
    }
}
