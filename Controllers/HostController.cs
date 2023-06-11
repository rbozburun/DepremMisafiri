using DepremMisafiri.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepremMisafiri.Controllers
{
    public class HostController : Controller
    {
        public IRepository repository;

        public HostController(IRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult HostList()
        {
            return View(repository.Hosts);
        }
    }
}
