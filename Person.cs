namespace SandBox
{
    internal class Person
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string name, int yearOfBirth)
        {
            Name = name;
            yearOfBirth = YearOfBirth;
        }
    }
}
