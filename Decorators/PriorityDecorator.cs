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

        //virtual or abstract?? de adaugat
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override BaseTask Clone()
        {
            throw new NotImplementedException();
        }

    }
}
