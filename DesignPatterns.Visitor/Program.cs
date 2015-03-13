using DesignPatterns.Visitor.Elements;
using DesignPatterns.Visitor.Visitors;
using System;

namespace DesignPatterns.Visitor
{
    /// <summary>
    /// The visitor pattern represents an operation to be performed on the elements of an object structure.
    /// A visitor lets you define a new operation without changing the classes of the elements on which it operates.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Employees();
            employees.Attach(new Employee("Hank", 25000.0, 14));
            employees.Attach(new Employee("Mark", 35000.0, 15));
            employees.Attach(new Employee("Alex", 70000.0, 16));

            employees.Accept(new IncomeVisitor());
            employees.Accept(new VacationVisitor());

            Console.ReadLine();
        }
    }
}
