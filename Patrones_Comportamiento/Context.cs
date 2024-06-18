namespace Patrones_Comportamiento;


// Es la clase que tiene un estado.
// Contiene una referencia a una instancia de uno de los estados concretos
// y delega a ella el comportamiento que depende del estado.
public class Context
{
    private State _state;

    public Context(State state)
    {
        ChangeState(state);
    }

    public void ChangeState(State state)
    {
        Console.WriteLine($"Context: Changing state to {state.GetType().Name}.");
        _state = state;
        _state.SetContext(this);
    }

    public void Request1()
    {
        _state.Handle1();
    }

    public void Request2()
    {
        _state.Handle2();
    }
}