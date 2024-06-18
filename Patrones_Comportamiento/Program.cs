// See https://aka.ms/new-console-template for more information

using Patrones_Comportamiento;

Context context = new Context(new ConcreteStateA());
context.Request1();
Console.WriteLine();
context.Request2();