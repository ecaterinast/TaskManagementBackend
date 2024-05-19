using TaskManagement.Data.DbModels;

namespace TaskManagement.Interfaces
{
    public interface IObserver
    {
        void Update(BaseTask task);
    }
}
