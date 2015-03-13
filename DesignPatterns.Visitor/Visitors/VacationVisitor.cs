using DesignPatterns.Visitor.Elements;
using System;

namespace DesignPatterns.Visitor.Visitors
{
    public class VacationVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            var employee = element as Employee;
            employee.VacationDays += 3;
            Console.WriteLine("{0}'s new vacation days: {1}", employee.Name, employee.VacationDays);
        }
    }
}
