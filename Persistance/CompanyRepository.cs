using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PraktikTracker.Data;
using PraktikTracker.Models;

namespace PraktikTracker.Persistance
{
    public class CompanyRepository : ICompanyRepository
    {
        private PraktikDbContext _context;
        public CompanyRepository(PraktikDbContext context)
        {
            _context = context;
        }
        public void Add(Company company)
        {
            if (company != null)
            {
                _context.Companies.Add(company);
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var company = _context.Companies.Find(id);
            if (company != null)
            {
                _context.Companies.Remove(company);
                _context.SaveChanges();
            }
        }

        public List<Company> GetAll()
        {
            return _context.Companies.ToList();
        }

        public Company GetById(int id)
        {
            var foundCompany = _context.Companies.Find(id);
            if (foundCompany != null)
            {
                return foundCompany;
            }
            throw new Exception("Company not found");
        }

        public void Update(int id)
        {
            var company = _context.Companies.Find(id);
            if (company != null)
            {
                _context.Companies.Update(company);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Company not found");
            }
        }
    }
}