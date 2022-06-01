using Microsoft.AspNetCore.Mvc;

namespace QMSCharts.Controllers
{
    public class QMSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TotalsByStatus()
        {
            return View();
        }

        public IActionResult DaysToResolveTickets()
        {
            return View();
        }
        public IActionResult DaysToResolveTicketsForMultipleOrgs()
        {
            return View();
        }

        public IActionResult DaysToResolveTicketsOnceAtPPRM()
        {
            return View();
        }

        public IActionResult TicketsByOrganizationCreatedAt()
        {
            return View();
        }

        public IActionResult TotalsByOrganization()
        {
            return View();
        }

        public IActionResult TicketsByNOA()
        {
            return View();
        }

        public IActionResult ErrorTypeCounts()
        {
            return View();
        }
    }
}
