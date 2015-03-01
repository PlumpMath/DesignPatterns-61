using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VirtualProxy
{
    public class Company
    {
        public Company()
        {
        }

        public Company(Company company, IList<Employee> employees)
        {
            this.Id = company.Id;
            this.Name = company.Name;
            Employees = employees;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Employee> Employees { get; private set; }
    }
}
