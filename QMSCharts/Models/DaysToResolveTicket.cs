namespace QMSCharts.Models
{
    public class DaysToResolveTicket
    {
        public DaysToResolveTicket(int id, string daysOldRange, int total)
        {
            Id = id;
            DaysOldRange = daysOldRange;
            Total = total;
        }

        public int Id { get; set; }

        public string DaysOldRange { get; set; } = String.Empty;

        public int Total { get; set; }
    }
}
