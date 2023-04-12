using KubernetesAzure.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KubernetesAzure.Controllers
{
    public class HomeController : Controller
    {

        private readonly EmployeeContext _dbContext;
        public HomeController(EmployeeContext dbcontext) { _dbContext = dbcontext; }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            return View(_dbContext.Employees.OrderBy(e => e.Nombre));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}