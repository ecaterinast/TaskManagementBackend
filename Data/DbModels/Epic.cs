namespace TaskManagement.Data.DbModels
{
    public class Epic : BaseTask
    {
        List <BaseTask> tasks { get; set; }
        public Epic()
        {
            
        }

        public override void CreateTask()
        {
            Console.WriteLine("An epic was created!");
        }

        public override BaseTask Clone()
        {
            Console.WriteLine("A simple task was cloned!");
            return this.MemberwiseClone() as Epic;
        }
    }
}
