using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using QMSCharts.Models;

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

            Console.WriteLine($"\n[QMSDashboardController][GetTotalsByStatus] => (grandTotal: {grandTotal})");

            foreach (var tbs in totalsByStatus)
            {
                tbs.Percentage = tbs.Total / grandTotal;
            }

            return totalsByStatus;
        }
    }
}
