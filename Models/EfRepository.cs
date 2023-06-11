namespace DepremMisafiri.Models
{
    public class EfRepository : IRepository
    {
        private DataContext context;
        public EfRepository(DataContext _context)
        {
            context = _context;
        }

        // When the user requests for Admins from Db, repository sends Admins from the context.
        public IEnumerable<Admin> Admins { get => context.Admins; set => throw new NotImplementedException(); }
        public IEnumerable<EarthquakeVictim> EarthquakeVictims { get => context.EarthquakeVictims; set => throw new NotImplementedException(); }
        public IEnumerable<Editor> Editors { get => context.Editors; set => throw new NotImplementedException(); }
        public IEnumerable<Host> Hosts { get => context.Hosts; set => throw new NotImplementedException(); }
        public IEnumerable<House> Houses { get => context.Houses; set => throw new NotImplementedException(); }
        public IEnumerable<Request> Requests { get => context.Requests; set => throw new NotImplementedException(); }

        public House GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<House> GetHouses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<House> GetHousesByStatus()
        {
            throw new NotImplementedException();
        }

    }
}
