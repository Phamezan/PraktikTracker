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
            Company newCompany = new Company();
            return View(newCompany);
        }

        [HttpPost]
        public IActionResult Add(Company company)
        {
            if (ModelState.IsValid)
            {
                _services.AddCompany(company);
                ViewData["Message"] = "Firmaet er blevet tilføjet";
                return RedirectToAction("Index");
            }
            return View(company);
        }

        public IActionResult Edit(int id)
        {
            var company = _services.GetCompanyById(id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }
        [HttpPost]
        public IActionResult Edit(Company company)
        {
            if (ModelState.IsValid)
            {
                _services.UpdateCompany(company.Id);
                ViewData["Message"] = "Firmaet er blevet opdateret";
                return RedirectToAction("Index");
            }
            return View(company);
        }
    }
}