using Microsoft.AspNetCore.Mvc;

namespace expensesapp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
