using AutoMapper;
using bookstore.DTO;
using bookstore.IRepository;
using bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace bookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : Controller
{
    private readonly IBookRep _context;
    private readonly IMapper _mapper;

    public BookController(IBookRep book, IMapper mapper)
    {
        _mapper = mapper;
        _context = book;
    }

    [HttpGet]
    public IActionResult GetBooks()
    {
        var book = _context.GetBooks();
        var BooksDto = _mapper.Map<IEnumerable<BookDTO>>(book);
        return Ok(BooksDto);
    }

    [HttpGet("{name}")]
    public IActionResult GetBook(string name)
    {
        var sht = _context.GetBook(name);
        var shtdto = _mapper.Map<BookDTO>(sht);
        return Ok(shtdto);
    }

    [HttpPut("{title}")]
    public IActionResult Update(string title, Book name)
    {
        _context.UpdateBook(title, name);

        return NoContent();
    }

    [HttpDelete("{name}")]
    public IActionResult DeleteBook(string name)
    {
        _context.DeleteBook(name);
        return NoContent();
    }

    [HttpPost]
    public IActionResult AddBook(Book name)
    {
        _context.AddBook(name);
        return NoContent();
    }
}