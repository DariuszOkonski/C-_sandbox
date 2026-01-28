//Console.WriteLine("==== Pizza app ====");

//var ingredients = new List<Ingredient>
//{
//    new Cheddar(), new TomatoSauce(), new Mozzarella()
//};

//foreach (Ingredient ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}


using SandBox.NumbersSumCalculator;

Console.WriteLine("==== numbers sum calculator ====");
var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
var sum = new NumbersSumCalculator().Calculate(numbers);

Console.WriteLine("Sum is: " + sum);
