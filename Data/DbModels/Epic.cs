namespace TaskManagement.Data.DbModels
{
    public class Epic : BaseTask
    {
        List <ItemTask> tasks { get; set; }
        public Epic()
        {
            
        }

        int CalculateTotalHours()
        {
            return tasks.Count;
        }
        public override void Create()
        {
            Console.WriteLine("An epic was created!");
        }

        public override void AddDescription()
        {
            Console.WriteLine("Add Description to an epic."); ;
        }

        public override void AddLink()
        {
            Console.WriteLine("Added a Link to an epic.");
        }

        public override void AddHours()
        {
            Console.WriteLine("Added Hours to an epics.");
        }
    }
}
