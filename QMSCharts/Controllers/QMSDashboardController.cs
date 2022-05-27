using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using QMSCharts.Models;
using QMSCharts.Services;
using System.Globalization;

namespace QMSCharts.Controllers
{
    public class QMSDashboardController : Controller
    {
        public readonly QMSDashboardService _service;
        public QMSDashboardController()
        {
            _service = new QMSDashboardService();
        }

        public ActionResult TotalsByStatus_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(_service.GetTotalsByStatus());
        }

        public ActionResult DatysToResolveTickets_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(_service.GetDaysToResolveTickets());
        }

    }
}
