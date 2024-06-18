// See https://aka.ms/new-console-template for more information

using Patrones_Comportamiento;

//Es una estructura de objetos que puede contener varios elementos ConcreteElement.
//Permite que los visitantes visiten los elementos.
List<IElement> elements = new List<IElement>
{
    new ConcreteElementA(),
    new ConcreteElementB()
};

Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
var visitor1 = new ConcreteVisitor1();
Client.ClientCode(elements, visitor1);

Console.WriteLine();

Console.WriteLine("It allows the same client code to work with different types of visitors:");
var visitor2 = new ConcreteVisitor2();
Client.ClientCode(elements, visitor2);