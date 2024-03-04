using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Data;
using TaskManagement.Data.DbModels;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private DataContext _dataContext;
        public TaskController(DataContext dbContext)
        {
            _dataContext = dbContext;
        }
        [HttpGet]
        public ItemTask GetTask()
        {
            return new ItemTask()
            {
                Name = "task 1"
            };
        }

        [HttpPost]
        public void Add(TaskModel task)
        {
            _dataContext.Add(task);
            // functional add a task
        }

        [HttpDelete]
        public void Delete(TaskModel task)
        {
            // functional delete a task
        }
    }
}
