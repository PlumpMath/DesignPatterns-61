using DesignPatterns.Visitor.Visitors;
using System.Collections.Generic;

namespace DesignPatterns.Visitor.Elements
{
    public class Employees : IElement
    {
        private List<Employee> employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var employee in employees)
            {
                employee.Accept(visitor);
            }
        }
    }
}
