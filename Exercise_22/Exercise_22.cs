namespace SandBox.Exercise_22
{
    internal class Exercise_22
    {
        public List<int> GetCountsOfAnimalsLegs()
        {
            var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider(),
            };

            var result = new List<int>();
            foreach (var animal in animals)
            {
                result.Add(animal.NumberOfLegs);
            }


            return result;
        }
    }
}

//using SandBox.Exercise_22;

//var exercise = new Exercise_22();
//var numberOfLegs = 0;

//foreach (var item in exercise.GetCountsOfAnimalsLegs())
//{
//	numberOfLegs += item;
//}

//Console.WriteLine("Number of animals: " + exercise.GetCountsOfAnimalsLegs().Count);
//Console.WriteLine("Number or legs: " + numberOfLegs);

//Console.ReadLine();