using TaskManagement.Interfaces;

namespace TaskManagement.Data.DbModels
{
    public class CompositeTask : BaseTask
    {
        List<IBaseTask> tasks = new List<IBaseTask>();
        public CompositeTask() { }

        public override BaseTask Clone()
        {
            throw new NotImplementedException();
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override int CalculateTotalHours()
        {
            return base.CalculateTotalHours();
        }
    }
}
