using DepremMisafiri.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepremMisafiri.Controllers
{
    public class HouseController : Controller
    {

        private IRepository repository;
        public HouseController(IRepository _repository)
        {
            repository = _repository;

        }
        public IActionResult HouseList()
        {
            return View(repository.Houses);
        }
    }
}
