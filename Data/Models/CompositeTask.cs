using TaskManagement.Data.DbModels;
using TaskManagement.Interfaces;

namespace TaskManagement.Data.Models
{
    public class CompositeTask : IBaseTask
    {
        List<BaseTask> tasks = new List<BaseTask>();
        public CompositeTask() { }

        public void AddDescription()
        {
            throw new NotImplementedException();
        }

        public int CalculateTotalHours()
        {
            return CalculateTotalHours();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }
    }
}
