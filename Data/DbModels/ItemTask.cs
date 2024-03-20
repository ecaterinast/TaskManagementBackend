
namespace TaskManagement.Data.DbModels
{
    public class ItemTask : BaseTask
    {
        public ItemTask() { }

        public override void CreateTask()
        {
            Console.WriteLine("A simple task was created!");
        }

        public override BaseTask Clone()
        {
            Console.WriteLine("A simple task was cloned!");
            return this.MemberwiseClone() as ItemTask;
        }

        public override void AddAssignee()
        {
            Console.WriteLine("Assigned a person to a simple task."); ;
        }

        public override void AddDescription()
        {
            Console.WriteLine("Add Description to a simple task."); ;
        }

        public override void AddLink()
        {
            Console.WriteLine("Added a Link for a simple task.");
        }
    }
}
