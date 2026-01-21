namespace SandBox
{
    internal class Rectangle
    {
        private int _height;

        public Rectangle(int width, int height)
        {
            Width = GetLengthOrDefault(width, nameof(Width));
            _height = GetLengthOrDefault(height, nameof(_height));
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
    }
}
