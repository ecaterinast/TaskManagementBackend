using Microsoft.AspNetCore.Components.Forms;
using TaskManagement.Interfaces;

namespace TaskManagement.Data.DbModels
{
    public abstract class BaseTask : IBaseTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TaskCreated { get; set; }
        public DateTime DueDate { get; set; }
        private bool IsCompleted { get; set; }
        public string Status { get; set; }
        public int Hours { get; set; }
        public abstract void Create(); // implementation of Factory Method
        public abstract BaseTask Clone(); // implementation of Prototype

        // Implementation of Builder
        public abstract void AddDescription(); //virtual or abstract ???
        public abstract void AddLink();
        public abstract void AddAssignee();

        public abstract void AddHours(); // Composite + builder

        // Implementation of Decorator
        public virtual string GetDescription()
        {
            return $"Title: {Name}\nDescription: {Description}\nDue Date: {DueDate}";
        }
    }
}
