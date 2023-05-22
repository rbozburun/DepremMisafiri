using Microsoft.AspNetCore.Identity;

namespace DepremMisafiri.Models
{
    public class Admin
    {
        // Admin user's property cannot be null, therefore "?" added.
        public int? Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
