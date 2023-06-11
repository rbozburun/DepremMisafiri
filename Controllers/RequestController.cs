using DepremMisafiri.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepremMisafiri.Controllers
{
    public class RequestController : Controller
    {
        private IRepository repository;
        public RequestController(IRepository _repository)
        {
            repository = _repository;

        }
        public IActionResult RequestList()
        {
            return View(repository.Requests);
        }
    }
}
