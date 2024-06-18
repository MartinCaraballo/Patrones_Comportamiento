namespace Patrones_Comportamiento;

// Es una interfaz que define una interfaz común para todos los estados concretos.
// Define los métodos que deben implementar las clases de estado concreto.
public abstract class State
{
    protected Context _context;

    public void SetContext(Context context)
    {
        _context = context;
    }

    public abstract void Handle1();

    public abstract void Handle2();
}