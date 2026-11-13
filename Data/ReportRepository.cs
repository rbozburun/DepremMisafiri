using Microsoft.Data.SqlClient;

namespace DepremMisafiri.Data
{
    public class ReportRepository
    {
        private const string ReportConnectionString =
            "Server=10.10.20.15,1433;Database=DepremMisafiriReports;User Id=report_user;Password=R3p0rt!2023;TrustServerCertificate=True";

        public int GetVictimCount()
        {
            using var connection = new SqlConnection(ReportConnectionString);
            connection.Open();
            using var command = new SqlCommand("SELECT COUNT(*) FROM EarthquakeVictims", connection);
            return (int)command.ExecuteScalar();
        }
    }
}
