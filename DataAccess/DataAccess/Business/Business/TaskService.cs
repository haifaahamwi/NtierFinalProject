using System.Collections.Generic;
using System.Linq;
using NtierFinalProject.DataAccess;
using NtierFinalProject.Models;

namespace NtierFinalProject.Business
{
    public class TaskService
    {
        private readonly TaskRepository repository;
        public TaskService(TaskRepository repo) => repository = repo;
        public List<TaskItem> GetTasks() => repository.GetAll();
        public void AddTask(string title)
        {
            if (string.IsNullOrWhiteSpace(title)) return;
            var tasks = repository.GetAll();
            int newId = tasks.Any() ? tasks.Max(t => t.Id) + 1 : 1;
            repository.Add(new TaskItem { Id = newId, Title = title, IsComplete = false });
        }
        public void CompleteTask(int id)
        {
            var task = repository.GetById(id);
            if (task != null) task.IsComplete = true;
        }
    }
}
