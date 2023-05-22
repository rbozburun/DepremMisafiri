namespace DepremMisafiri.Models
{
    public class EarthquakeVictim
    {
        // Cannot be null, "?" added.
        public int? Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Location { get; set; }

    }
}
