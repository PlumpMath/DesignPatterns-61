using DesignPatterns.Visitor.Visitors;

namespace DesignPatterns.Visitor.Elements
{
    public class Employee : IElement
    {
        public Employee(string name, double income, int vacationDays)
        {
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }

        public string Name { get; set; }

        public double Income { get; set; }

        public int VacationDays { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
