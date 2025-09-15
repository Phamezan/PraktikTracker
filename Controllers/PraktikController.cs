using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PraktikTracker.Models;
using PraktikTracker.Services;

namespace PraktikTracker.Controllers
{
    public class PraktikController : Controller
    {
        private readonly CompanyServices _services;
        public PraktikController(CompanyServices services)
        {
            _services = services;
        }
        public IActionResult Index()
        {
            var companies = _services.GetAllCompanies();
            return View(companies);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Company company)
        {
            if (ModelState.IsValid)
            {
                _services.AddCompany(company);
                return RedirectToAction("Index");
                ViewData["Message"] = "Firmaet er blevet tilføjet";
            }
            return View(company);
        }
    }
}