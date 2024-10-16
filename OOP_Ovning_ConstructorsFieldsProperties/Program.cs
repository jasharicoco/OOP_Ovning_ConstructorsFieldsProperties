namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("A Fish", "Kulusevski", 1204);
            Book book2 = new Book("Stories of magnificent places", "Charles Bukowski", 185);
            Book book3 = new Book("Understanding women", "The Wisest Man", 1982132521);

            book1.Present();
            book2.Present();
            book3.Present();
        }
    }
}
