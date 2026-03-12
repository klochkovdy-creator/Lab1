namespace OOP_Fundamentals_Library
{
    public class Manager : Employee
    {
        private string _department;
        private List<Employee> _team = new();

        public string Department
        {
            get => _department;
            set => _department = value ?? throw new ArgumentNullException(nameof(Department));
        }

        public IReadOnlyList<Employee> Team => _team.AsReadOnly();

        public Manager(string name, int age, decimal salary, string position, string department)
            : base(name, age, salary, position)
        {
            Department = department;
        }

        public void AddToTeam(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));
            if (!_team.Contains(employee))
                _team.Add(employee);
        }

        public bool RemoveFromTeam(Employee employee) => _team.Remove(employee);

        public void AssignTaskToEmployee(Employee emp, string task)
        {
            if (emp == null)
                throw new ArgumentNullException(nameof(emp));
            Console.WriteLine($"Assigning task '{task}' to {emp.Name}");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"  Department: {Department}, Team size: {_team.Count}");
        }

        public override void GenerateReport()
        {
            base.GenerateReport();
            Console.WriteLine($"  Department: {Department}");
            Console.WriteLine($"  Team size: {_team.Count}");
        }

        public override decimal CalculateBonus(int yearsOfWork, bool hasCertification)
        {
            decimal bonus = Salary * 0.2m; 
            if (yearsOfWork > 5)
                bonus += 500;
            if (hasCertification)
                bonus += 300;
            return bonus;
        }

        public override decimal GetRaiseAmount() => 2000;
    }
}