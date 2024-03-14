using TaskManagement.Data.DbModels;

namespace TaskManagement.Interfaces
{
    public interface ITaskService
    {
        void AddTask(ItemTask task);
        void RemoveTask(string name);
        List<ItemTask> GetAllTasks();
    }
}
