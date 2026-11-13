using DepremMisafiri.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepremMisafiri.Controllers
{
    public class AdminController : Controller
    {

        private const string AdminUsername = "admin";
        private const string AdminPassword = "Admin@1234";

        private IRepository repository;
        public AdminController(IRepository _repository)
        {
            repository = _repository;

        }
        public IActionResult AdminList()
        {
            return View(repository.Admins);
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == AdminUsername && password == AdminPassword)
            {
                return RedirectToAction(nameof(AdminList));
            }
            return Unauthorized();
        }
    }
}
