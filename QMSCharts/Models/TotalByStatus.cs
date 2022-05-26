namespace QMSCharts.Models
{
    public class TotalByStatus
    {
        public TotalByStatus(int id, string status, int total)
        {
            Id = id;
            Status = status;
            Total = total;
        }

        public int Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public int Total { get; set; }
        public double Percentage { get; set; }

        public string StatusAndPercentage { get; set; } = string.Empty;
    }
}
