namespace OOP_Fundamentals_Library
{
    public abstract class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");
                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 150)
                    throw new ArgumentOutOfRangeException(nameof(Age), "Age must be between 0 and 150");
                _age = value;
            }
        }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public virtual void GenerateReport()
        {
            Console.WriteLine($"Report for {Name}:");
            Console.WriteLine($"  Name: {Name}");
            Console.WriteLine($"  Age: {Age}");
        }
    }
}