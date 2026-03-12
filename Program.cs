using OOP_Fundamentals_Library;

class Program
{
    static void Main()
    {
        try
        {
            var customer = new Customer("John", 30);
            var employee = new Employee("Alice", 25, 50000, "Developer");
            var manager = new Manager("Bob", 40, 80000, "Manager", "IT");

            manager.AddToTeam(employee);

            employee.Salary = 55000;

            Console.WriteLine("=== Информация о людях ===");
            customer.PrintInfo();
            employee.PrintInfo();
            manager.PrintInfo();

            var payroll = new PayrollSystem();
            Console.WriteLine("\n=== Обработка зарплаты ===");
            payroll.ProcessSalary(employee);
            payroll.ProcessSalary(manager);

            Console.WriteLine("\n=== Отчёты ===");
            ReportService.GenerateReport(customer);
            ReportService.GenerateReport(employee);
            ReportService.GenerateReport(manager);

            Console.WriteLine("\n=== Бонусы ===");
            int years = 6;
            bool cert = true;
            decimal bonusEmp = payroll.CalculateBonus(employee, years, cert);
            decimal bonusMgr = payroll.CalculateBonus(manager, years, cert);
            Console.WriteLine($"Employee bonus: {bonusEmp:C}");
            Console.WriteLine($"Manager bonus: {bonusMgr:C}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}