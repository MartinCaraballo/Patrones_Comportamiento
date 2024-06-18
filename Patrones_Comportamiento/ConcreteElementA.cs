namespace Patrones_Comportamiento;

// Son las clases que implementan la interfaz Element.
// Implementan el método accept y, por lo general, tienen lógica adicional relacionada con el elemento.
public class ConcreteElementA : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentA(this);
    }
    
    public string ExclusiveMethodOfConcreteComponentA()
    {
        return "A";
    }
}