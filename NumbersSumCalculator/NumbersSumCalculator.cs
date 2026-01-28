namespace SandBox.NumbersSumCalculator
{
    public class NumbersSumCalculator
    {
        public int Calculate(List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
