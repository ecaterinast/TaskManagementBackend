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

        public override void AddAssignee()
        {
            Console.WriteLine("Assigned a person to an epic."); ;
        }

        public override void AddDescription()
        {
            Console.WriteLine("Add Description to an epic."); ;
        }

        public override void AddLink()
        {
            Console.WriteLine("Added a Link to an epic.");
        }
    }
}
