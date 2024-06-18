namespace Patrones_Comportamiento;

// Estas son las clases que implementan la interfaz Visitor.
// Implementan cada uno de los métodos de visita definidos en la interfaz Visitor.
public class ConcreteVisitor2 : IVisitor
{
    public void VisitConcreteElementA(ConcreteElementA element)
    {
        Console.WriteLine(element.ExclusiveMethodOfConcreteElementA() + " + ConcreteVisitor2");
    }

    public void VisitConcreteElementB(ConcreteElementB element)
    {
        Console.WriteLine(element.SpecialMethodOfConcreteElementB() + " + ConcreteVisitor2");
    }
}