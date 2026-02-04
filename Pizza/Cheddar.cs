public class Cheddar : Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths)
        : base(priceIfExtraTopping)
    {
        Console.WriteLine("Construstor from the Cheddar class");
        AgedForMonths = agedForMonths;
    }

    public override string Name =>
        $"{base.Name}, more specifcally, a Cheddar cheese aged for {AgedForMonths} months";
    public int AgedForMonths { get; }

    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
    }
}
