// See https://aka.ms/new-console-template for more information

using Patrones_Comportamiento;

var context = new Context();

Console.WriteLine("Client: Strategy is set to normal sorting.");
context.SetStrategy(new ConcreteStrategyA());
context.DoSomething();
            
Console.WriteLine();
            
Console.WriteLine("Client: Strategy is set to reverse sorting.");
context.SetStrategy(new ConcreteStrategyB());
context.DoSomething();