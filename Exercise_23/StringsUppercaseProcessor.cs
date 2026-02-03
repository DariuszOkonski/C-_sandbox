
namespace SandBox.Exercise_23
{
    internal class StringsUppercaseProcessor : StringsProcessor
    {
        public override List<string> Process(List<string> input)
        {
            List<string> result = new List<string>();

            foreach (var item in input)
            {
                result.Add(item.ToUpper());
            }

            return result;
        }
    }
}
