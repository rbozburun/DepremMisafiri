using DepremMisafiri.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepremMisafiri.Controllers
{
    public class AdminController : Controller
    {

        private IRepository repository;
        public AdminController(IRepository _repository)
        {
            repository = _repository;

        }
        public IActionResult AdminList()
        {
            return View(repository.Admins);
        }
    }
}
