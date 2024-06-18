namespace Patrones_Comportamiento;

// Son clases que implementan la interfaz Strategy. Cada una de ellas encapsula un algoritmo específico.
public class ConcreteStrategyB : IStrategy
{
    public object DoAlgorithm(object data)
    {
        var list = data as List<string>;
        list.Sort();
        list.Reverse();

        return list;
    }
}