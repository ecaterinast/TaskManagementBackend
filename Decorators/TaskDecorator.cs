using TaskManagement.Data.DbModels;

namespace TaskManagement.Decorators
{
    public abstract class TaskDecorator : BaseTask
    {
        protected BaseTask Item { get; set; }
        public TaskDecorator(BaseTask task)
        {
            Item = task;
        }
        public override string GetDescription()
        {
            return Item.GetDescription();
        }
    }
}
