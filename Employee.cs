namespace OOP_Fundamentals_Library
{
    public class Employee : Person
    {
        private decimal _salary;
        private string _position;

        public decimal Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative");
                _salary = value;
            }
        }

        public string Position
        {
            get => _position;
            set => _position = value ?? throw new ArgumentNullException(nameof(Position));
        }

        public Employee(string name, int age, decimal salary, string position) : base(name, age)
        {
            Salary = salary;
            Position = position;
        }

        public void IncreaseSalary(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException("Increase amount cannot be negative");
            Salary += amount;
        }

        public virtual void ProcessPayroll()
        {
            Console.WriteLine($"Processing payroll for {Name}: {Salary:C}");
        }

        public virtual decimal CalculateBonus(int yearsOfWork, bool hasCertification)
        {
            decimal bonus = Salary * 0.1m; 
            if (yearsOfWork > 5)
                bonus += 500;
            if (hasCertification)
                bonus += 300;
            return bonus;
        }

        public virtual decimal GetRaiseAmount() => 1000;

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"  Position: {Position}, Salary: {Salary:C}");
        }

        public override void GenerateReport()
        {
            base.GenerateReport();
            Console.WriteLine($"  Position: {Position}");
            Console.WriteLine($"  Salary: {Salary:C}");
        }
    }
}