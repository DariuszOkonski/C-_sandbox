using SandBox.Pizza;

public class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {

    }
    public override string Name => "Mozarella";
    public bool IsLight { get; }
}