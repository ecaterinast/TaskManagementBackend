using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Reflection.Metadata.Ecma335;

namespace TaskManagement.Data.DbModels
{
    public class Bug : BaseTask
    {
        public Bug(string relatedTaskTitle)
        {
            relatedTaskTitle  = taskTitle;
        }
        public bool isFixed {  get; set; }
        public string taskTitle { get; set; }

        public override Bug Clone()
        {
            Console.WriteLine("A bug task was cloned!");
            return this.MemberwiseClone() as Bug;
        }

        public override void Create()
        {
            Console.WriteLine("A bug was created!");
        }

        public override void AddAssignee()
        {
            Console.WriteLine("Assigned a person to a bug."); ;
        }

        public override void AddDescription()
        {
            Console.WriteLine("Add Description to a bug."); ;
        }

        public override void AddLink()
        {
            Console.WriteLine("Added a Link for a bug.");
        }

        public override void AddHours()
        {
            Console.WriteLine("Added Hours for a bug.");
        }
    }
}
