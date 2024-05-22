using TaskManagement.Data.DbModels;

namespace TaskManagement.Decorators
{
    public class PriorityDecorator : TaskDecorator
    {
        private string Priority { get; set; }
        public PriorityDecorator(BaseTask task, string priority) : base(task)
        {
            Priority = priority;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + $"\n(Priority: {Priority})";
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }

    }
}
