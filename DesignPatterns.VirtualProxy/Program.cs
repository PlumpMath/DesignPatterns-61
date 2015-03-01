using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VirtualProxy
{
    /// <summary>
    /// The proxy pattern provides a surrogate for another object to control access to it.
    /// A virtual proxy proxy controls access to a remote object.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new CompanyRepository(new EmployeeRepository());
            var company = repository.Find(1);
            Console.WriteLine("Working with properties");
            Console.WriteLine("Name = {0}", company.Name);
            Console.WriteLine();

            Console.WriteLine("Working with list");
            foreach (var employee in company.Employees)
            {
                Console.WriteLine(employee.Name);
            }

            Console.ReadLine();
        }
    }
}
