using DepremMisafiri.Models;

namespace DepremMisafiri.Data
{
    public class EditorRepository : IEditorRepository
    {
        private DataContext context;
        public EditorRepository(DataContext _context)
        {
            context = _context;
        }

        public IEnumerable<Editor> Editors { get => context.Editors; set => throw new NotImplementedException(); }

        public Editor GetById(int id)
        {
            return context.Editors.Find(id);
        }

        public void UpdateEditor(Editor updatedEditor)
        {
            context.Editors.Update(updatedEditor);
            context.SaveChanges();

        }
    }
}
