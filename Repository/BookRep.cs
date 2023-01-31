using bookstore.Context;
using bookstore.IRepository;
using bookstore.Models;

namespace bookstore.Repository;

public class BookRep : IBookRep
{
    private readonly Data _context;

    public BookRep(Data objcontext)
    {
        _context = objcontext;
    }


    public List<Book> GetBooks()
    {
        return _context.Book.OrderBy(a => a.Price).ToList();
    }

    public Book GetBook(string name)
    {
        return _context.Book.Where(a => a.Name == name).FirstOrDefault();
    }

    public Book AddBook(Book name)
    {
        _context.Book.Add(name);
        _context.SaveChanges();
        return name;
    }

    public void DeleteBook(string name)
    {
        var x = _context.Book.Where(a => a.Name == name).FirstOrDefault();
        _context.Remove(x);
        _context.SaveChanges();
    }

    public void UpdateBook(string title, Book name)
    {
        DeleteBook(title);
        AddBook(name);
        _context.SaveChanges();
    }
}