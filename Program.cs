namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EBook aEbook = new EBook("Power", "Jeffery Pfeffer", 2011, 208);

            PrintedBook aPrintedBook = new PrintedBook("Wind and Truth", "Brandon Sanderson", 2024, 1248);

            Console.WriteLine(aEbook.ToString());
            Console.WriteLine(aPrintedBook.ToString());
        }
    }
}
