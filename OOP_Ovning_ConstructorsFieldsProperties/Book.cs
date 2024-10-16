namespace OOP_Ovning_ConstructorsFieldsProperties
{
    internal class Book
    {
        private string _Title { get; set; }
        private string _Author { get; set; }
        private int _NumberOfPages { get; set; }

        public Book(string title, string author, int numberOfPages)
        {
            _Title = title;
            _Author = author;
            _NumberOfPages = numberOfPages;
        }

        public void Present()
        {
            Console.WriteLine($"{_Title} ({_NumberOfPages} pages), by {_Author}");
        }
    }
}
