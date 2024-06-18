namespace Patrones_Comportamiento;

// Es un objeto que almacena el estado del Originator.
// Esencialmente, es una representación del estado interno del Originator,
// pero no debe permitir que ningún otro objeto modifique su contenido.
public class ConcreteMemento : IMemento
{

    private readonly string _state;

    private readonly DateTime _date;
    
    public ConcreteMemento(string state)
    {
        _state = state;
        _date = DateTime.Now;
    }
    
    public string GetName()
    {
        return $"{_date} / {_state}";
    }

    public string GetState()
    {
        return _state;
    }

    public DateTime GetDate()
    {
        return _date;
    }
}