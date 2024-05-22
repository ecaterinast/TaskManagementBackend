using TaskManagement.Data.DbModels;

namespace TaskManagement.Interfaces
{
    public interface ITaskController
    {
        void AddTask (ItemTask task); // TaskType type
        void RemoveTask(string name);
        List<ItemTask> GetAllTasks ();
    }
}
