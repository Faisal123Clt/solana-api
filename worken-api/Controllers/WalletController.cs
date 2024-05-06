using Microsoft.AspNetCore.Mvc;

namespace worken_api.Controllers
{
    public class WalletController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
