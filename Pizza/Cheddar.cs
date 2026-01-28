public class Cheddar : Ingredient
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}
