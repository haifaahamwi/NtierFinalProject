using Microsoft.AspNetCore.Mvc;
using NtierFinalProject.Business;
using NtierFinalProject.DataAccess;
using NtierFinalProject.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskService _taskService;
        public HomeController()
        {
            var repository = new TaskRepository();
            _taskService = new TaskService(repository);
        }
        public IActionResult Index() => View(_taskService.GetTasks());
        [HttpPost] public IActionResult AddTask(string title) { _taskService.AddTask(title); return RedirectToAction("Index"); }
        [HttpPost] public IActionResult CompleteTask(int id) { _taskService.CompleteTask(id); return RedirectToAction("Index"); }
    }
}
