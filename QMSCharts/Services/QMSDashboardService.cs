using QMSCharts.Models;
using System.Globalization;

namespace QMSCharts.Services
{
    public class QMSDashboardService
    {
        //public IEnumerable<DaysToResolveTicket> GetDaysToResolveTickets()
        //{
        //    var daysToResolveTickets = new DaysToResolveTicket[]
        //    {
        //        new DaysToResolveTicket(1, "0-1 Days", 679),
        //        new DaysToResolveTicket(2, "2-5 Days", 441),
        //        new DaysToResolveTicket(3, "6-10 Days", 372),
        //        new DaysToResolveTicket(4, "11-15 Days", 177),
        //        new DaysToResolveTicket(5, "16-20 Days", 90),
        //        new DaysToResolveTicket(6, "21-25 Days", 72),
        //        new DaysToResolveTicket(7, "31+ Days", 138),
        //        new DaysToResolveTicket(8, "60+ Days", 54),
        //        new DaysToResolveTicket(9, "90+ Days", 67),
        //    };

        //    Console.WriteLine("[QMSDashboardService][GetDaysToResolveTickets] =>");

        //    return daysToResolveTickets;
        //}

        public IEnumerable<QMSChart> GetDaysToResolveTickets()
        {
            var daysToResolveTickets = new QMSChart[]
            {
                new QMSChart(1, "0-1 Days", 679),
                new QMSChart(2, "2-5 Days", 441),
                new QMSChart(3, "6-10 Days", 372),
                new QMSChart(4, "11-15 Days", 177),
                new QMSChart(5, "16-20 Days", 90),
                new QMSChart(6, "21-25 Days", 72),
                new QMSChart(7, "31+ Days", 138),
                new QMSChart(8, "60+ Days", 54),
                new QMSChart(9, "90+ Days", 67),
            };

            return daysToResolveTickets;
        }


        public IEnumerable<QMSChart> GetTotalsByOrganization()
        {
            var totalsByOrganization = new QMSChart[]
            {
                new QMSChart(1, "CABS HR Service Center", 5),
                new QMSChart(2, "Executive Resources Service Center", 1),
                new QMSChart(3, "FAS Service Center", 25),
                new QMSChart(4, "PBS Service Center", 36),
                new QMSChart(5, "Processing Center", 27),
                new QMSChart(6, "Staff Offices Service Center", 25),
            };

            int grandTotal = 0;
            foreach (var tbo in totalsByOrganization)
            {
                grandTotal += tbo.Value;
            }

            foreach (var tbo in totalsByOrganization)
            {
                double percentage = (double)tbo.Value / (double)grandTotal;
                string percentageAsString = percentage.ToString("P1", CultureInfo.CreateSpecificCulture("en-US"));
                tbo.Key = $"{tbo.Key} ({percentageAsString})";
            }

            return totalsByOrganization;
        }

        public IEnumerable<QMSChart> GetTotalsByStatus()
        {
            var totalsByStatus = new QMSChart[]
            {
                new QMSChart(1, "Assigned", 79),
                new QMSChart(2, "Closed - Action Completed", 1916),
                new QMSChart(3, "Closed - No Action Required", 234),
                new QMSChart(4, "Draft", 10),
                new QMSChart(5, "Pending Review", 11),
                new QMSChart(6, "Returned", 92),
                new QMSChart(7, "Unassigned", 5),
            };

            int grandTotal = 0;
            foreach (var tbs in totalsByStatus)
            {
                grandTotal += tbs.Value;
            }

            foreach (var tbs in totalsByStatus)
            {
                double percentage = (double)tbs.Value / (double)grandTotal;
                string percentageAsString = percentage.ToString("P1", CultureInfo.CreateSpecificCulture("en-US"));
                tbs.Key = $"{tbs.Key} ({percentageAsString})";
            }

            return totalsByStatus;
        }

        //public IEnumerable<TotalByStatus> GetTotalsByStatus()
        //{
        //    var totalsByStatus = new TotalByStatus[]
        //    {
        //        new TotalByStatus(1, "Assigned", 79),
        //        new TotalByStatus(2, "Closed - Action Completed", 1916),
        //        new TotalByStatus(3, "Closed - No Action Required", 234),
        //        new TotalByStatus(4, "Draft", 10),
        //        new TotalByStatus(5, "Pending Review", 11),
        //        new TotalByStatus(6, "Returned", 92),
        //        new TotalByStatus(7, "Unassigned", 5),
        //    };

        //    int grandTotal = 0;
        //    foreach (var tbs in totalsByStatus)
        //    {
        //        grandTotal += tbs.Total;
        //    }

        //    foreach (var tbs in totalsByStatus)
        //    {
        //        tbs.Percentage = (double)tbs.Total / (double)grandTotal;
        //        string percentageAsString = tbs.Percentage.ToString("P1", CultureInfo.CreateSpecificCulture("en-US"));
        //        tbs.StatusAndPercentage = $"{tbs.Status} ({percentageAsString})";
        //    }

        //    return totalsByStatus;
        //}
    }
}
