using DepremMisafiri.Models;

namespace DepremMisafiri.Data
{
    public interface IHostRepository
    {
        IEnumerable<Models.Host> Hosts { get; set; }
        Models.Host GetById(int id);
        public void UpdateHost(Models.Host updatedHost);
    }
}
