using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VirtualProxy
{
    public class EmployeeRepository
    {
        public IList<Employee> GetEmployeesByCompanyId(int id)
        {
            return GetEmployees().Where(c => c.CompanyId == id).ToList();
        }

        private IList<Employee> GetEmployees()
        {
            Console.WriteLine("Retrieving the employees");
            return new List<Employee>() 
            { 
                new Employee(){ Name = "John", CompanyId = 1 },
                new Employee() { Name = "Alex", CompanyId = 1 },
                new Employee() { Name = "Tom", CompanyId = 2 }
            };
        }
    }
}
