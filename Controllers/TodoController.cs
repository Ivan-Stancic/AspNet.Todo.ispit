using AspNet.TODO.Repository.Interfaces;
using AspNet.TODO.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.TODO.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoRepository todoRespository;
        private readonly ILogger<HomeController> logger;

        public TodoController(ILogger<HomeController> logger, ITodoRepository todoRespository)
        {
            this.logger = logger;
            this.todoRespository = todoRespository;
        }
        public IActionResult View()
        {
            return View(todoRespository.Get());
        }
    }
}