namespace DepremMisafiri.Models
{
    public interface IRepository
    {

        IEnumerable<Admin> Admins { get; set; }
        IEnumerable<EarthquakeVictim> EarthquakeVictims { get; set; }
        IEnumerable<Editor> Editors { get; set; }
        IEnumerable<Host> Hosts { get; set; }
        IEnumerable<House> Houses { get; set; }
        IEnumerable<Request> Requests { get; set; }


        House GetById(int id);

        IEnumerable<House> GetHouses();
        IEnumerable<House> GetHousesByStatus();

    }
}
