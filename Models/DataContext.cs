using Azure.Core;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace DepremMisafiri.Models
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // Write models that will be migrated
        public DbSet<Editor> Editors { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Host> Hosts { get; set; }

        public DbSet<EarthquakeVictim> EarthquakeVictims { get; set; }

        public DbSet<Request> Requests { get; set; }

        public DbSet<House> Houses { get; set; }

    }
}
