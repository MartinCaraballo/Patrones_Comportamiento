namespace Patrones_Comportamiento;

// Son las clases que implementan la interfaz State y definen el
// comportamiento asociado con un estado particular del Contexto.
public class ConcreteStateA : State
{
    public override void Handle1()
    {
        Console.WriteLine("ConcreteStateA handles request1.");
        Console.WriteLine("ConcreteStateA wants to change the state of the context.");
        _context.ChangeState(new ConcreteStateB());
    }

    public override void Handle2()
    {
        Console.WriteLine("ConcreteStateA handles request2.");
    }
}