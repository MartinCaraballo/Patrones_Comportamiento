namespace Patrones_Comportamiento;

// Son las clases que implementan la interfaz State y definen el
// comportamiento asociado con un estado particular del Contexto.
public class ConcreteStateB : State
{
    public override void Handle1()
    {
        Console.WriteLine("ConcreteStateB handles request 1.");
    }

    public override void Handle2()
    {
        Console.WriteLine("ConcreteStateB handles request 2.");
        Console.WriteLine("ConcreteStateB wants to change the state of the context.");
        _context.ChangeState(new ConcreteStateA());
    }
}