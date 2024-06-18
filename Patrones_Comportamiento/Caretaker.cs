namespace Patrones_Comportamiento;

// Es responsable de mantener un registro de los diferentes estados del Originator mediante mementos.
// El Caretaker solo debe almacenar y recuperar mementos; no debe alterarlos ni examinar su contenido.
public class Caretaker
{
    private Stack<IMemento> _mementos = new Stack<IMemento>();

    private Originator _originator;

    public Caretaker(Originator originator)
    {
        _originator = originator;
    }

    public void Backup()
    {
        Console.WriteLine("\nCaretaker: Saving Originator's state...");
        _mementos.Push(_originator.Save());
    }

    public void Undo()
    {
        if (_mementos.Count == 0)
        {
            return;
        }

        IMemento memento = _mementos.Pop();
        
        Console.WriteLine($"Caretaker: Restoring state to: {memento.GetName()}");

        try
        {
            _originator.Restore(memento);
        }
        catch (Exception)
        {
            Undo();
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("Caretaker: Here's the list of mementos:");

        foreach (IMemento memento in _mementos)
        {
            Console.WriteLine(memento.GetName());
        }
    }
    
}