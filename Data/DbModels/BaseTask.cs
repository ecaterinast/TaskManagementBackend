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
        public string Status { get; set; }
        public abstract void CreateTask(); // implementation of Factory Method
        public abstract BaseTask Clone(); // implementation of Prototype

        // Implementation of Builder
        public abstract void AddDescription();
        public abstract void AddLink();
        public abstract void AddAssignee();
    }
}
