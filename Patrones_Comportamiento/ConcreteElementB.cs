namespace Patrones_Comportamiento;

// Son las clases que implementan la interfaz Element.
// Implementan el método accept y, por lo general, tienen lógica adicional relacionada con el elemento.
public class ConcreteElementB : IElement
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteComponentB(this);
    }
    
    public string SpecialMethodOfConcreteComponentB()
    {
        return "B";
    }
}