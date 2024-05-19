using TaskManagement.Data.DbModels;

namespace TaskManagement.Interfaces
{
    public interface ITaskHandler
    {
        bool Handle(BaseTask task);
        void SetNextHandler(ITaskHandler handler);
    }
}
