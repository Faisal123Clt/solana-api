using Microsoft.AspNetCore.Mvc;

namespace worken_api.Controllers
{
    public class TransactionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
