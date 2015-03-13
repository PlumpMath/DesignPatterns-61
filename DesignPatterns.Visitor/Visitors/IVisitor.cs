using DesignPatterns.Visitor.Elements;

namespace DesignPatterns.Visitor.Visitors
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}
