using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VirtualProxy
{
    public class CompanyRepository
    {
        private readonly EmployeeRepository employeeRepository;

        public CompanyRepository(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Company Find(int id)
        {
            return new Company(FindCompany(id), new VirtualProxyList<Employee>(() => employeeRepository.GetEmployeesByCompanyId(id)));
        }

        private Company FindCompany(int id)
        {
            return GetCompanies().Where(r => r.Id == id).FirstOrDefault();
        }

        private IList<Company> GetCompanies()
        {
            return new List<Company>() 
            { 
                new Company() { Id = 1, Name = "Microsoft" },
                new Company() { Id = 2, Name = "Google" }
            };
        }
    }
}
