//using SandBox.NumbersSumCalculator;

//var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
//bool shallAddPositiveOnly = true;
//int sum;

//var calculator = shallAddPositiveOnly
//        ? new PositiveNumbersSumCalculator()
//        : new NumbersSumCalculator();

//if (shallAddPositiveOnly)
//{
//    sum = calculator.Calculate(numbers);
//}
//else
//{

//    sum = calculator.Calculate(numbers);
//}


//Console.WriteLine("Sum is: " + sum);




using SandBox.Exercise_23;

Console.WriteLine("Exercise 23");
var exercise23 = new Exercise_23();

List<string> words = new List<string> { "bobcat", "wolverine", "grizzly" };
var result = exercise23.ProcessAll(words);

Console.WriteLine("ProcessAll: ");
foreach (var item in result)
{
    Console.WriteLine("item: " + item);
}

Console.ReadLine();