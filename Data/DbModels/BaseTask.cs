namespace TaskManagement.Data.DbModels
{
    public abstract class BaseTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TaskCreated { get; set; }
        public DateTime DueDate { get; set; }
        private bool IsCompleted { get; set; }
    }
}
