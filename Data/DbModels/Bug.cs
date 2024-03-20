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

        public override BaseTask Clone()
        {
            Console.WriteLine("A bug task was cloned!");
            return this.MemberwiseClone() as Bug;
        }

        public override void CreateTask()
        {
            Console.WriteLine("A bug was created!");
        }
    }
}
