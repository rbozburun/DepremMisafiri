using DepremMisafiri.Models;

namespace DepremMisafiri.Data
{
    public interface IEditorRepository
    {
        IEnumerable<Editor> Editors { get; set; }

        Editor GetById(int id);

        public void UpdateEditor(Editor updatedEditor);
    }
}
