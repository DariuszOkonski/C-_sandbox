
namespace SandBox.Exercise_23
{
    internal class StringsTrimmingProcessor : StringsProcessor
    {
        public override List<string> Process(List<string> input)
        {
            List<string> result = new List<string>();
            foreach (var item in input)
            {
                var newWord = item.Substring(0, item.Length / 2);
                result.Add(newWord);
            }

            return result;
        }

    }
}
