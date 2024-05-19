using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Data;
using TaskManagement.Data.DbModels;
using TaskManagement.Interfaces;
using TaskManagement.Models;
using TaskManagement.Service;

namespace TaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase, ITaskController
    {
        private ITaskService _service;

        public TaskController(DataContext dataContext)
        {
            _service = new TaskService(dataContext);
        }
        [HttpGet]
        public List<ItemTask> GetAllTasks()
        {
            return _service.GetAllTasks();
        }

        [HttpPost]
        public void AddTask([FromBody] BaseTask task, TaskType type)
        {
            _service.AddTask((ItemTask)task, type);
        }

        [HttpPost]
        [Route("delete")]
        public void RemoveTask(string name)
        {
            _service.RemoveTask(name);
        }
    }
}
