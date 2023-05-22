using System.ComponentModel.DataAnnotations.Schema;

namespace DepremMisafiri.Models
{
    public class House
    {
        public int? Id { get; set; }

        public bool? IsAccepted { get; set; }

        [ForeignKey("Host")]
        public int? HostId { get; set; }
        
        public Host? Host { get; set; }

        public int? MaxAvailableDays { get; set; }
        public string? Status { get; set; }
        public string? Location { get; set; }
        public int? MaxGuestCount { get; set; }
        public string? SpecialConditions { get; set; }

    }
}
