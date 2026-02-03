namespace SandBox.Exercise_23
{
    internal class Exercise_23
    {
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
            {
                new StringsTrimmingProcessor(),
                new StringsUppercaseProcessor()
            };

            List<string> result = words;

            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }
}

//using SandBox.Exercise_23;

//Console.WriteLine("Exercise 23");
//var exercise23 = new Exercise_23();

//List<string> words = new List<string> { "bobcat", "wolverine", "grizzly" };
//var result = exercise23.ProcessAll(words);

//Console.WriteLine("ProcessAll: ");
//foreach (var item in result)
//{
//	Console.WriteLine("item: " + item);
//}

//Console.ReadLine();