namespace Patrones_Comportamiento;


// Es el objeto cuyo estado queremos guardar y restaurar.
// Tiene un método que crea un memento conteniendo una instantánea de su estado actual,
// y otro método que restaura su estado a partir de un memento.
public class Originator
{
    private string _state;

    public Originator(string state)
    {
        _state = state;
        Console.WriteLine($"Originator: My initial state is {state}");
    }

    public void DoSomething()
    {
        Console.WriteLine("Originator: Doing some operation...");
        _state = this.GenerateRandomString(30);
        Console.WriteLine($"Originator: My state has changed to {_state}");
    }

    private string GenerateRandomString(int length = 10)
    {
        string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string result = string.Empty;

        while (length > 0)
        {
            result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

            Thread.Sleep(12);

            length--;
        }

        return result;
    }

    public IMemento Save()
    {
        return new ConcreteMemento(_state);
    }

    public void Restore(IMemento memento)
    {
        if (!(memento is ConcreteMemento))
        {
            throw new Exception($"Unknown memento class {memento.ToString()}");
        }

        _state = memento.GetState();
        Console.WriteLine($"My state was restored to {_state}");
    }
}