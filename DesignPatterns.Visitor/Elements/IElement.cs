using DesignPatterns.Visitor.Visitors;

namespace DesignPatterns.Visitor.Elements
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
