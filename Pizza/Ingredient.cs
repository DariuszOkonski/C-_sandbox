public class Ingredient
{
    public virtual string Name { get; } = "Some ingredient";
    public int PublicField;

    public string PublicMethod() =>
        "This method is PUBLIC in the Ingredient class";

    protected string ProtectedMethod() =>
        "This method is PROTECTED in the Ingredient class";

    private string PrivateMethod() =>
        "This method is PRIVATE in the Ingredient class";
}