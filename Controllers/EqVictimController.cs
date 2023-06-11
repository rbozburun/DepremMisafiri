using DepremMisafiri.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepremMisafiri.Controllers
{
    public class EqVictimController : Controller
    {
        public IRepository repository;

        public EqVictimController(IRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult EqVictimList()
        {
            return View(repository.EarthquakeVictims);
        }
    }
}
