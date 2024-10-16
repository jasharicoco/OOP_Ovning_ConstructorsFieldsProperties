namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Book
            Book book1 = new Book("A Fish", "Kulusevski", 1204);
            Book book2 = new Book("Stories of magnificent places", "Charles Bukowski", 185);
            Book book3 = new Book("Understanding women", "The Wisest Man", 1982132521);

            book1.Present();
            book2.Present();
            book3.Present();

            // Bank Account

            BankAccount account1 = new BankAccount("252525");

            account1.Deposit(200);
            account1.Withdrawal(150);
            Console.WriteLine($"Account overdrawn? {account1.IsOverdrawn}");
            account1.Withdrawal(210);
            Console.WriteLine($"Account overdrawn? {account1.IsOverdrawn}");

            // Circle

            Circle circle1 = new Circle(5);

            Console.WriteLine($"{circle1.Area}");
            circle1.IncreaseByFactor(2);
            Console.WriteLine($"{circle1.Area}");
        }
    }
}
