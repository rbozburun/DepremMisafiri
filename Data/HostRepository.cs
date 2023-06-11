using DepremMisafiri.Models;

namespace DepremMisafiri.Data
{
    public class HostRepository : IHostRepository
    {
        private DataContext context;
        public HostRepository(DataContext _context)
        {
            context = _context;
        }

        public IEnumerable<Models.Host> Hosts { get => context.Hosts; set => throw new NotImplementedException(); }

        public Models.Host GetById(int id)
        {
            return context.Hosts.Find(id);
        }

        public void UpdateHost(Models.Host updatedHost)
        {
            context.Hosts.Update(updatedHost);
            context.SaveChanges();
        }
    }
}
