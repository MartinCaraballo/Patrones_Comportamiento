namespace Patrones_Comportamiento;

// Son clases que implementan la interfaz Strategy. Cada una de ellas encapsula un algoritmo específico.
public class ConcreteStrategyA : IStrategy
{
    public object DoAlgorithm(object data)
    {
        var list = data as List<string>;
        list.Sort();

        return list;
    }
}