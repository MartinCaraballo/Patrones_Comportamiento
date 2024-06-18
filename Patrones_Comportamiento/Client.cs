namespace Patrones_Comportamiento;

// Es la parte del código que quiere realizar operaciones sobre
// los objetos de las clases concretas sin conocerlas.
public class Client
{
    public static void ClientCode(List<IElement> elements, IVisitor visitor)
    {
        foreach (var component in elements)
        {
            component.Accept(visitor);
        }
    }
}