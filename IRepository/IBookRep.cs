using bookstore.Models;

namespace bookstore.IRepository;

public interface IBookRep
{
    List<Book> GetBooks();
    Book GetBook(string name);
    Book AddBook(Book name);
    void DeleteBook(string name);
    void UpdateBook(string title, Book name);
}