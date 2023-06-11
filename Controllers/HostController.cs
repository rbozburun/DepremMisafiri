using DepremMisafiri.Data;
using DepremMisafiri.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepremMisafiri.Controllers
{
    public class HostController : Controller
    {
        public IHostRepository repository;

        public HostController(IHostRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult HostList()
        {
            return View(repository.Hosts);
        }

        public IActionResult Edit(int id)
        {
            return View(GetById(id));
        }

        // Retrieves Host from DB with ID
        public Models.Host GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Edit(Models.Host host)
        {
            repository.UpdateHost(host);
            return RedirectToAction(nameof(HostList));
        }
    }
}
