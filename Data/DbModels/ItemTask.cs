
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
    }
}
