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
        public virtual void AddDescription() { Console.WriteLine("Description added"); } 
        public virtual void AddLink() { Console.WriteLine("Link added"); }
        public virtual void AddAssignee() { Console.WriteLine("Assignee added"); }
        public virtual void AddHours() { Console.WriteLine("Hours added"); } // Composite + builder

        // Implementation of Decorator
        public virtual string GetDescription()
        {
            return $"Title: {Name}\nDescription: {Description}\nDue Date: {DueDate}";
        }
        // Implementation of Coomposite
        public virtual int CalculateTotalHours()
        {
            Console.WriteLine($"Hours = {Hours}");
            return Hours;
        }
    }
}
