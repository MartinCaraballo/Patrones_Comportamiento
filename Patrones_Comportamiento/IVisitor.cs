namespace Patrones_Comportamiento;

// Es una interfaz que declara un conjunto de métodos de visita, uno para cada tipo concreto de
// elemento en la estructura de objetos. Cada método de visita acepta un único argumento,
// que es uno de los tipos de elementos de la estructura.
public interface IVisitor
{
    void VisitConcreteComponentA(ConcreteElementA element);

    void VisitConcreteComponentB(ConcreteElementB element);
}