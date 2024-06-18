namespace Patrones_Comportamiento;

// Estas son las clases que implementan la interfaz Visitor.
// Implementan cada uno de los métodos de visita definidos en la interfaz Visitor.
public class ConcreteVisitor1 : IVisitor
{
    public void VisitConcreteComponentA(ConcreteElementA element)
    {
        Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor1");
    }

    public void VisitConcreteComponentB(ConcreteElementB element)
    {
        Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor1");
    }
}