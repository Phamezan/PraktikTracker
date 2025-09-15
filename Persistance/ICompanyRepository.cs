using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PraktikTracker.Models;

namespace PraktikTracker.Persistance
{
    public interface ICompanyRepository
    {
        void Add(Company company);
        List<Company> GetAll();
        Company GetById(int id);
        void Update(int id);
        void Delete(int id);
    }
}