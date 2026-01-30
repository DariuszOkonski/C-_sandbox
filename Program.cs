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

using SandBox.Exercise_22;

var exercise = new Exercise_22();
var numberOfLegs = 0;

foreach (var item in exercise.GetCountsOfAnimalsLegs())
{
    numberOfLegs += item;
}

Console.WriteLine("Number of animals: " + exercise.GetCountsOfAnimalsLegs().Count);
Console.WriteLine("Number or legs: " + numberOfLegs);

Console.ReadLine();