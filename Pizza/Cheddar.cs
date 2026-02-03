using SandBox.Pizza;

public class Cheddar : Cheese
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}
