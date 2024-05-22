using TaskManagement.Data.DbModels;
using TaskManagement.Data.Enums;
using TaskManagement.Interfaces;

namespace TaskManagement.Service
{
    public class NotificationService : IObserver

    {
        public void Update(BaseTask task)
        {
            if (task.Priority == TaskPriority.High)
            {
                Console.WriteLine("Sending notification for high priority task: {0}", task.Description);
            }
        }

    }
}
