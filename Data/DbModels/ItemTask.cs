
namespace TaskManagement.Data.DbModels
{
    public class ItemTask : BaseTask
    {
        public ItemTask() { }

        public override void Create()
        {
            Console.WriteLine("A simple task was created!");
        }

        public override void AddDescription()
        {
            Console.WriteLine("Add Description to a simple task."); ;
        }

        public override void AddLink()
        {
            Console.WriteLine("Added a Link for a simple task.");
        }

        public override void AddHours()
        {
            Console.WriteLine("Added Hours for a task.");
        }
    }
}
