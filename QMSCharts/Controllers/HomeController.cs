using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QMSCharts.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QMSCharts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
