using SandBox;

//Console.WriteLine($"1 + 2 is {Calculator.Add(1, 2)}");
//Console.WriteLine($"1 - 2 is {Calculator.Subtract(1, 2)}");
//Console.WriteLine($"1 * 2 is {Calculator.Multiply(1, 2)}");

//Console.WriteLine(Rectangle.DescribeGenerally());
//Console.WriteLine(Rectangle.NumberOfSides);

var rectangle1 = new Rectangle(1, 1);
var rectangle2 = new Rectangle(2, 2);

Console.WriteLine("Count of Rectangle objects is " + Rectangle.CountOfInstances);