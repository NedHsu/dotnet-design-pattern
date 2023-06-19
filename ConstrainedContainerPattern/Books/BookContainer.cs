public class BookContainer : ContainerInterface
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        if (book is Novel || book is ProfessionalBook)
        {
            books.Add(book);
            Console.WriteLine($"Added {book.Title} to the container.");
        }
        else
        {
            Console.WriteLine($"Cannot add {book.Title} to the container. Only novels and professional books are allowed.");
        }
    }

    public Book GetBook()
    {
        if (books.Count > 0)
        {
            Book book = books[0];
            books.RemoveAt(0);
            Console.WriteLine($"Got {book.Title} from the container.");
            return book;
        }
        else
        {
            Console.WriteLine("The container is empty.");
            return null;
        }
    }
}
