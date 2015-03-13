using DesignPatterns.Visitor.Elements;
using System;

namespace DesignPatterns.Visitor.Visitors
{
    public class IncomeVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            var employee = element as Employee;
            employee.Income *= 1.1;
            Console.WriteLine("{0}'s new income: {1:C}", employee.Name, employee.Income);
        }
    }
}
