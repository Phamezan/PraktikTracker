using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PraktikTracker.Models;
using PraktikTracker.Persistance;

namespace PraktikTracker.Services
{
    public class CompanyServices
    {
        private readonly ICompanyRepository _repo;
        public CompanyServices(ICompanyRepository repo)
        {
            _repo = repo;
        }

        public void AddCompany(Company company)
        {
            _repo.Add(company);
        }
        public List<Company> GetAllCompanies()
        {
            return _repo.GetAll();
        }
        public Company GetCompanyById(int id)
        {
            return _repo.GetById(id);
        }
        public void UpdateCompany(int id)
        {
            _repo.Update(id);
        }
        public void DeleteCompany(int id)
        {
            _repo.Delete(id);
        }
    }
}