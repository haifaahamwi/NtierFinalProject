using System.Collections.Generic;
using System.Linq;
using NtierFinalProject.Models;

namespace NtierFinalProject.DataAccess
{
    public class TaskRepository
    {
        private List<TaskItem> tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Title = "مهمة أولى", IsComplete = false },
            new TaskItem { Id = 2, Title = "مهمة ثانية", IsComplete = false }
        };
        public List<TaskItem> GetAll() => tasks;
        public void Add(TaskItem task) => tasks.Add(task);
        public TaskItem GetById(int id) => tasks.FirstOrDefault(t => t.Id == id);
    }
}
