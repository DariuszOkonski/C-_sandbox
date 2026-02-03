using SandBox.Pizza;

var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new Mozzarella());
pizza.AddIngredient(new TomatoSauce());

Console.WriteLine(pizza);


//var cheddar = new Cheddar();

//Console.WriteLine(new TomatoSauce());
//Console.WriteLine(new Rectangle(1, 1));
//Console.WriteLine(new List<int>());

Console.ReadLine();