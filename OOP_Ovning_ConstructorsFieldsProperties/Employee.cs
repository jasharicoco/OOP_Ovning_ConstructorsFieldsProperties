namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Employee
    {
        private string Name { get; set; }
        private string Position { get; set; }
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Negative salary not accepted. You need a raise, sir!");
                }
                salary = value;
            }
        }

        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public void Present()
        {
            Console.WriteLine($"{Name} is our {Position} and earns {salary} dollars a month.");
        }

        public decimal YearlyIncome()
        {
            return salary * 12;
        }
    }
}
