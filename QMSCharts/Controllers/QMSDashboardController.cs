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

        public ActionResult DaysToResolveTickets_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(_service.GetDaysToResolveTickets());
        }
        public ActionResult DaysToResolveTicketsOnceAtPPRM_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(_service.GetDaysToResolveTicketsOnceAtPPRM());
        }
        public ActionResult TicketsByOrganizationCreatedAt_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(_service.GetTicketsByOrganizationCreatedAt());
        }
        public ActionResult TotalsByOrganization_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(_service.GetTotalsByOrganization());
        }
        public ActionResult TicketsByNOA_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(_service.GetTicketsByNOA);
        }

    }
}
