using System.ComponentModel.DataAnnotations.Schema;

namespace DepremMisafiri.Models
{
    public class Request
    {
        public int? Id { get; set; }

        [ForeignKey("EarthquakeVictim")]
        public int? EqVictimId { get; set; }
        public EarthquakeVictim? EarthquakeVictim { get; set; }

        [ForeignKey("House")]
        public int? HouseId { get; set; }
        public House? House { get; set; }

        public int? GuestCount { get; set; }

    }
}
