namespace Patrones_Comportamiento;

// Es una interfaz común a todos los algoritmos soportados.
// Declara un método que se utiliza para ejecutar un algoritmo.
public interface IStrategy
{
    object DoAlgorithm(object data);
}