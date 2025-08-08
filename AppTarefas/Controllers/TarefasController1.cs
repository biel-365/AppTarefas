using Microsoft.AspNetCore.Mvc;

namespace AppTarefas.Controllers
{
    public class TarefasController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
