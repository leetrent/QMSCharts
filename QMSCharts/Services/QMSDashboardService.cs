using QMSCharts.Models;
using System.Globalization;

namespace QMSCharts.Services
{
    public class QMSDashboardService
    {
        public IEnumerable<DaysToResolveTicket> GetDaysToResolveTickets()
        {
            var daysToResolveTickets = new DaysToResolveTicket[]
            {
                new DaysToResolveTicket(1, "0-1 Days", 679),
                new DaysToResolveTicket(2, "02-5 Days", 441),
                new DaysToResolveTicket(3, "06-10 Days", 372),
                new DaysToResolveTicket(4, "11-15 Days", 177),
                new DaysToResolveTicket(5, "16-20 Days", 90),
                new DaysToResolveTicket(6, "21-25 Days", 72),
                new DaysToResolveTicket(7, "31+ Days", 138),
                new DaysToResolveTicket(8, "60+ Days", 54),
                new DaysToResolveTicket(9, "90+ Days", 67),
            };

            Console.WriteLine("[QMSDashboardService][GetDaysToResolveTickets] =>");

            return daysToResolveTickets;
        }

        public IEnumerable<TotalByStatus> GetTotalsByStatus()
        {
            var totalsByStatus = new TotalByStatus[]
            {
                new TotalByStatus(1, "Assigned", 79),
                new TotalByStatus(2, "Closed - Action Completed", 1916),
                new TotalByStatus(3, "Closed - No Action Required", 234),
                new TotalByStatus(4, "Draft", 10),
                new TotalByStatus(5, "Pending Review", 11),
                new TotalByStatus(6, "Returned", 92),
                new TotalByStatus(7, "Unassigned", 5),
            };

            int grandTotal = 0;
            foreach (var tbs in totalsByStatus)
            {
                grandTotal += tbs.Total;
            }

            foreach (var tbs in totalsByStatus)
            {
                tbs.Percentage = (double)tbs.Total / (double)grandTotal;
                string percentageAsString = tbs.Percentage.ToString("P1", CultureInfo.CreateSpecificCulture("en-US"));
                tbs.StatusAndPercentage = $"{tbs.Status} ({percentageAsString})";
            }

            return totalsByStatus;
        }
    }
}
