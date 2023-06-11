using DepremMisafiri.Data;
using DepremMisafiri.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepremMisafiri.Controllers
{
    public class EditorController : Controller
    {
        private IEditorRepository repository;
        public EditorController(IEditorRepository _repository)
        {
            repository = _repository;

        }
        public IActionResult EditorList()
        {
            return View(repository.Editors);
        }

        // Retrieves Editor from DB with ID
        public Editor GetById(int id)
        {
            return repository.GetById(id);
        }

        public IActionResult Edit(int id)
        {
            return View(GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Editor editor)
        {
            repository.UpdateEditor(editor);
            return RedirectToAction(nameof(EditorList));
        }
    }
}
