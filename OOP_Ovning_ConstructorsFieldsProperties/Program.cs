namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Book

            Console.WriteLine("Book");

            Book book1 = new Book("A Fish", "Kulusevski", 1204);
            Book book2 = new Book("Stories of magnificent places", "Charles Bukowski", 185);
            Book book3 = new Book("Understanding women", "The Wisest Man", 1982132521);

            book1.Present();
            book2.Present();
            book3.Present();

            // Bank Account

            Console.WriteLine("\nBank Account");

            BankAccount account1 = new BankAccount("252525");

            account1.Deposit(200);
            account1.Withdrawal(150);
            Console.WriteLine($"Account overdrawn? {account1.IsOverdrawn}");
            account1.Withdrawal(210);
            Console.WriteLine($"Account overdrawn? {account1.IsOverdrawn}");

            // Circle
            Console.WriteLine("\nCircle");

            Circle circle1 = new Circle(5);

            Console.WriteLine($"{circle1.Area}");
            circle1.IncreaseByFactor(2);
            Console.WriteLine($"{circle1.Area}");

            // Employee
            Console.WriteLine("\nEmployee");

            Employee employee1 = new Employee("Frank", "Boss", 500);
            employee1.Present();
            Console.WriteLine($"{employee1.YearlyIncome()} dollars a year.");

            // Temperature
            Console.WriteLine("\nTemperature");

            Temperature temp1 = new Temperature(50);
            temp1.ShowTemp();
            temp1.AddTemp(10);
            temp1.ShowTemp();

            // Car
            Console.WriteLine("\nCar");

            Car car1 = new Car("Toyota", "X-Fly", 2001);
            Car car2 = new Car("Honda", "Civic", 1986);
            Car car3 = new Car("FillipinoDelux", "Oskarshamn", 2016);

            Console.WriteLine($"Number of Cars in our catalogue: {Car.InstanceCount}");
            Console.WriteLine($"Average age of the Cars in our catalogue: {Car.AverageAge()}");
        }
    }
}
