﻿using Microsoft.EntityFrameworkCore;
using TaskManagement.Data;
using TaskManagement.Data.DbModels;
using TaskManagement.Interfaces;

namespace TaskManagement.Service
{
    public class TaskService : ITaskService
    {
        private static TaskService _instance;

        private DataContext _dataContext;
        private TaskService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public static TaskService GetInstance(DataContext dataContext)
        {
            if (_instance == null)
            {
                _instance = new TaskService(dataContext);
            }
            return _instance;
        }
        public void AddTask(ItemTask task)
        {
            _dataContext.Add(task);
            _dataContext.SaveChanges();
        }

        public List<ItemTask> GetAllTasks()
        {
            return _dataContext.Tasks.ToList();
        }

        public void RemoveTask(string name)
        {
            var items = _dataContext.Tasks;
            ItemTask item = items.FirstOrDefault(n => n.Name == name);
            if (item != null)
            {
                _dataContext.Remove(item);
                _dataContext.SaveChanges();
            }
        }

        public void CloneTask (BaseTask task)
        {
            task.Clone();
        }

    }
}
