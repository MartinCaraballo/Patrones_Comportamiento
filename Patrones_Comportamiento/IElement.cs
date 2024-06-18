namespace Patrones_Comportamiento;

// Es una interfaz que declara un método accept que acepta un objeto de tipo Visitor como argumento.
public interface IElement
{
    void Accept(IVisitor visitor);
}