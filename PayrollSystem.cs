namespace OOP_Fundamentals_Library
{
    public class PayrollSystem
    {
        public void ProcessSalary(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            decimal raise = employee.GetRaiseAmount();
            employee.IncreaseSalary(raise);
            Console.WriteLine($"Processing salary for {employee.Name}: new salary = {employee.Salary:C}");
        }

        public void ProcessSalaries(IEnumerable<Employee> employees)
        {
            foreach (var emp in employees)
                ProcessSalary(emp);
        }

        public decimal CalculateBonus(Employee employee, int yearsOfWork, bool hasCertification)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));
            return employee.CalculateBonus(yearsOfWork, hasCertification);
        }
    }
}