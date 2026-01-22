namespace SandBox
{
    internal class Rectangle
    {
        public static int CountOfInstances { get; private set; }
        public static int NumberOfSides = 4;
        private int _height;

        public Rectangle(int width, int height)
        {
            Width = GetLengthOrDefault(width, nameof(Width));
            _height = GetLengthOrDefault(height, nameof(_height));
            ++CountOfInstances;
        }

        public int Width { get; }

        public int GetHeight() => _height;

        public void SetHeight(int value)
        {
            if (value > 0)
            {
                _height = value;
            }
        }

        private int GetLengthOrDefault(int length, string name)
        {
            const int DefaultValueIfNotPositive = 1;
            if (length <= 0)
            {
                Console.WriteLine($"{name} must ba a positive number");

                return DefaultValueIfNotPositive;
            }

            return length;
        }

        public int CalculateCircumference() => 2 * Width + 2 * _height;

        public int CalculateArea() => Width * _height;

        public string Description => $"A rectangle with widht: {Width} and height {_height}";

        public static string DescribeGenerally() => $"A plane figure with four straight sides and four right angles";

    }
}
