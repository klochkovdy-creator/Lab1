namespace OOP_Fundamentals_Library
{
    public class Customer : Person
    {
        public Customer(string name, int age) : base(name, age) { }

        public override void PrintInfo()
        {
            Console.Write("Customer: ");
            base.PrintInfo();
        }

        public override void GenerateReport()
        {
            Console.WriteLine($"Customer Report for {Name}:");
            base.GenerateReport();
        }
    }
}