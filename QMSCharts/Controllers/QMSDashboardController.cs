using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using QMSCharts.Models;
using System.Globalization;

namespace QMSCharts.Controllers
{
    public class QMSDashboardController : Controller
    {
        public ActionResult TotalsByStatus_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetTotalsByStatus());
        }

        private IEnumerable<TotalByStatus> GetTotalsByStatus()
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

            string logSnippet = "\n[QMSDashboardController][GetTotalsByStatus] =>";
            //Console.WriteLine($"\n{logSnippet} (grandTotal: {grandTotal})");

            foreach (var tbs in totalsByStatus)
            {
                tbs.Percentage = (double)tbs.Total / (double)grandTotal;
                string percentageAsString = tbs.Percentage.ToString("P1", CultureInfo.InvariantCulture);

                tbs.StatusAndPercentage = $"{tbs.Status} ({percentageAsString})";


                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"{logSnippet} (tbs.Total)..............: {tbs.Total})");
                Console.WriteLine($"{logSnippet} (grandTotal).............: {grandTotal})");
                Console.WriteLine($"{logSnippet} (tbs.Percentage).........: {tbs.Percentage})");
                Console.WriteLine($"{logSnippet} (percentageAsString).....: {percentageAsString})");
                Console.WriteLine($"{logSnippet} (tbs.StatusAndPercentage): {tbs.StatusAndPercentage})");
                Console.WriteLine("---------------------------------------------------------");

                //Console.WriteLine($"\n{logSnippet} (tbs.Percentage: {tbs.Percentage})");
                //Console.WriteLine($"\n{logSnippet} (tbs.Percentage: {tbs.Percentage})");
                //Console.WriteLine($"\n{logSnippet} (tbs.Percentage: {tbs.Percentage.ToString("P1", CultureInfo.InvariantCulture)})");
            }

            return totalsByStatus;
        }
    }
}
