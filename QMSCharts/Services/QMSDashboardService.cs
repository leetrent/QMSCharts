using QMSCharts.Models;
using System.Globalization;

namespace QMSCharts.Services
{
    public class QMSDashboardService
    {
        public IEnumerable<QMSChart> GetDaysToResolveTickets()
        {
            var daysToResolveTickets = new QMSChart[]
            {
                new QMSChart(1, "0-1", 679),
                new QMSChart(2, "2-5", 441),
                new QMSChart(3, "6-10", 372),
                new QMSChart(4, "11-15", 177),
                new QMSChart(5, "16-20", 90),
                new QMSChart(6, "21-25", 72),
                new QMSChart(7, "31+", 138),
                new QMSChart(8, "60+", 54),
                new QMSChart(9, "90+", 67),
            };

            return daysToResolveTickets;
        }

        public IEnumerable<QMSChart> GetDaysToResolveTicketsOnceAtPPRM()
        {
            var daysToResolveTicketsOnceAtPPRM = new QMSChart[]
            {
                new QMSChart(1,  "0-1", 960),
                new QMSChart(2,  "2-5", 382),
                new QMSChart(3,  "6-10", 289),
                new QMSChart(4,  "11-15", 145),
                new QMSChart(5,  "16-20", 68),
                new QMSChart(6,  "21-25", 55),
                new QMSChart(7,  "26-30", 48),
                new QMSChart(8,  "31+", 109),
                new QMSChart(9,  "60+", 40),
                new QMSChart(10, "90+", 54),
            };

            return daysToResolveTicketsOnceAtPPRM;
        }

        
        public IEnumerable<QMSChart> GetTicketsByOrganizationCreatedAt()
        {
            var ticketsByOrganizationCreatedAt = new QMSChart[]
            {
                new QMSChart(1,  "Benefits an...", 239),
                new QMSChart(2,  "CABS HR S...", 217),
                new QMSChart(3,  "Executive R.", 13),
                new QMSChart(4,  "FAS Service...", 852),
                new QMSChart(5,  "National Re...", 18),
                new QMSChart(6,  "Other/Pseu...", 13),
                new QMSChart(7,  "PBS Servic...", 671),
                new QMSChart(8,  "Staff Offices...", 324),
            };

            return ticketsByOrganizationCreatedAt;
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

        public IEnumerable<QMSChart> GetTicketsByNOA()
        {
            var ticketsByNOA= new QMSChart[]
            {
                new QMSChart(1,  "0", 1),
                new QMSChart(2,  "100", 52),
                new QMSChart(3,  "101", 196),
                new QMSChart(4,  "108", 21),
                new QMSChart(5,  "115", 19),
                new QMSChart(6,  "122", 1),
                new QMSChart(7,  "130", 173),
                new QMSChart(8,  "140", 27),
                new QMSChart(9,  "141", 6),
                new QMSChart(10,  "142", 1),
                new QMSChart(11,  "143", 1),
                new QMSChart(12,  "170", 188),
                new QMSChart(13,  "171", 72),
                new QMSChart(14,  "190", 17),
                new QMSChart(15,  "292", 5),
                new QMSChart(16,  "302", 1),
                new QMSChart(17,  "304", 1),
                new QMSChart(18,  "317", 7),
                new QMSChart(19,  "330", 1),
                new QMSChart(20,  "352", 7),
                new QMSChart(21,  "355", 3),
                new QMSChart(22,  "385", 4),
                new QMSChart(23,  "430", 1),
                new QMSChart(24,  "460", 9),
                new QMSChart(25,  "473", 12),
                new QMSChart(26,  "500", 37),
                new QMSChart(27,  "501", 62),
                new QMSChart(28,  "508", 15),
                new QMSChart(29,  "515", 2),
                new QMSChart(30,  "522", 2),
                new QMSChart(31,  "540", 1),
                new QMSChart(32,  "542", 1),
                new QMSChart(33,  "546", 1),
                new QMSChart(34,  "570", 21),
                new QMSChart(35,  "571", 17),
                new QMSChart(36,  "590", 4),
                new QMSChart(37,  "702", 273),
                new QMSChart(38,  "703", 63),
                new QMSChart(39,  "713", 19),
                new QMSChart(40,  "721", 204),
                new QMSChart(41,  "730", 6),
                new QMSChart(42,  "732", 3),
                new QMSChart(43,  "740", 1),
                new QMSChart(44,  "741", 1),
                new QMSChart(45,  "760", 20),
                new QMSChart(46,  "762", 2),
                new QMSChart(47,  "769", 2),
                new QMSChart(48,  "780", 5),
                new QMSChart(49,  "781", 4),
                new QMSChart(50,  "782", 3),
                new QMSChart(51,  "790", 23),
                new QMSChart(52,  "792", 34),
                new QMSChart(53,  "800", 24),
                new QMSChart(54,  "803", 19),
                new QMSChart(55,  "840", 12),
                new QMSChart(56, "841", 1),
                new QMSChart(57, "846", 6),
                new QMSChart(58, "849", 28),
                new QMSChart(59, "800", 21),
                new QMSChart(60, "881", 40),
                new QMSChart(61, "882", 44),
                new QMSChart(62, "883", 10),
                new QMSChart(63, "899", 2),
                new QMSChart(64, "906", 12),
                new QMSChart(65, "930", 82),
                new QMSChart(70, "931", 22),
                new QMSChart(71, "932", 42),
                new QMSChart(72, "981", 33),
                new QMSChart(73, "982", 6),
                new QMSChart(74, "991", 3),
                new QMSChart(75, "995", 22),
                new QMSChart(76, "999", 121),
            };

            return ticketsByNOA;
        }

    }
}
