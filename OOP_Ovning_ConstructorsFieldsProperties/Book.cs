namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Book
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private int NumberOfPages { get; set; }

        public Book(string _title, string _author, int numberOfPages)
        {
            Title = _title;
            Author = _author;
            NumberOfPages = numberOfPages;
        }

        public void Present()
        {
            Console.WriteLine($"{Title} ({NumberOfPages} pages), by {Author}");
        }
    }
}
